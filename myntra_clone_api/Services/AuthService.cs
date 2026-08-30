using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using myntra_clone_api.Twilio;
using System;
using System.Collections.Generic;
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
            SetOtpExpiration(phoneNumber, otp);

            var messageBody = $"your OTP for authentication: {otp}";

            var accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
            var authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

            if (string.IsNullOrEmpty(accountSid) || string.IsNullOrEmpty(authToken))
            {
                throw new InvalidOperationException("Twilio credentials are not set in environment variables.");
            }

            InitializeTwilioClient(accountSid, authToken);

            var messageResult = MessageResource.Create(
                body: messageBody,
                from: new PhoneNumber(_twilioConfig.PhoneNumber),
                to: new PhoneNumber(phoneNumber)
            );

            return messageResult.AccountSid;
        }

        public bool VerifyOTP(string phoneNumber, string otp)
        {
            if (!_otpStorage.TryGetValue(phoneNumber, out var storedOTP))
                return false;

            if (IsOtpExpired(storedOTP))
            {
                _otpStorage.Remove(phoneNumber);
                return false;
            }

            if (storedOTP.otp != otp)
                return false;

            _otpStorage.Remove(phoneNumber);
            return true;
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

        private void SetOtpExpiration(string phoneNumber, string otp)
        {
            var expirationTime = DateTime.Now.AddMilliseconds(10000);
            _otpStorage[phoneNumber] = (otp, expirationTime);
        }

        private bool IsOtpExpired((string otp, DateTime expirationTime) storedOTP)
        {
            return DateTime.Now > storedOTP.expirationTime;
        }

        private void InitializeTwilioClient(string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);
        }
    }
}