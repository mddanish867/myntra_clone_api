using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using myntra_clone_api.Twilio;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace myntra_clone_api.Services
{
    public class AuthService : IAuthService
    {
        private readonly TwilioConfig _twilioConfig;
        private readonly Random _random;
        private readonly Dictionary<string, (string otp, DateTime expirationTime)> _otpStorage;

        public AuthService(IOptions<TwilioConfig> twilioConfig)
        {
            _twilioConfig = twilioConfig.Value;
            _random = new Random();
            _otpStorage = new Dictionary<string, (string otp, DateTime expirationTime)>();
        }

        public string GenerateOTP()
        {
            // generate 4 digit OTP
            return _random.Next(1000, 9999).ToString();
        }

        public string SendOTPViaSMS(string phoneNumber, string otp)
        {
            // Set OTP Expiration time
            var expirationTime = DateTime.Now.AddMilliseconds(10000);
            _otpStorage[phoneNumber] = (otp, expirationTime);

            var messageBody = $"your OTP for authentication: {otp}";

            var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            if (string.IsNullOrEmpty(accountSid) || string.IsNullOrEmpty(authToken))
            {
                throw new InvalidOperationException("Twilio credentials are not set in environment variables.");
            }

            TwilioClient.Init(accountSid, authToken);
            var messageResult = MessageResource.Create(
                body: messageBody,
                from: new PhoneNumber(_twilioConfig.PhoneNumber),
                to: new PhoneNumber(phoneNumber)
            );

            return messageResult.AccountSid;
        }

        public bool VerifyOTP(string phoneNumber, string otp)
        {
            if (_otpStorage.ContainsKey(phoneNumber))
            {
                if (_otpStorage.TryGetValue(phoneNumber, out var storedOTP))
                {
                    // Check if OTP is still valid
                    if (DateTime.Now <= storedOTP.expirationTime)
                    {
                        if (storedOTP.otp == otp)
                        {
                            // Remove OTP after successful verification
                            _otpStorage.Remove(phoneNumber);
                            return true;
                        }
                    }
                    else
                    {
                        // OTP has expired. remove it from storage
                        _otpStorage.Remove(phoneNumber);
                    }
                }
            }
            return false;
        }

        public string GenerateToken(string phoneNumber)
        {
            var jwtSecret = Environment.GetEnvironmentVariable("JWT_SECRET");
            if (string.IsNullOrEmpty(jwtSecret))
            {
                throw new InvalidOperationException("JWT secret is not set in environment variables.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "https://localhost:7151",
                audience: "https://localhost:7151",
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
            );

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}