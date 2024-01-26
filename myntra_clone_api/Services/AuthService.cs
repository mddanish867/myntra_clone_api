using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using myntra_clone_api.Twilio;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System.Diagnostics;
using Twilio.TwiML.Voice;


namespace myntra_clone_api.Services
{
    public class AuthService : IAuthService
    {
        private readonly TwilioConfig _twilioConfig;
        private readonly Random _random;
        private readonly ILogger _logger;
        private readonly Dictionary<string, string> _otpStorage = new Dictionary<string, string>();

        public AuthService(IOptions<TwilioConfig> twilioConfig)
        {
            _twilioConfig = twilioConfig.Value;
            _random = new Random();
            //_otpStorage = new Dictionary<string, string>();
        }

        public string GenerateOTP()
        {
            // generate 4 digit OTP
            return _random.Next(1000, 9999).ToString();
        }

        public void SendOTPViaSMS(string phoneNumber, string otp)
        {
            var messageBody = $"your OTP for authentiation: {otp}";

            // Use Twilio API to send SMS with the generated OTP          
            var accountSid = "AC851567489afefff59ce7e7927f4b192d";
            var authToken = "92a215c1ae5f7006b50d59a55ef29bea";            


            TwilioClient.Init(accountSid, authToken);
            var messageResult = MessageResource.Create(
                body: messageBody,
                from: new PhoneNumber(_twilioConfig.PhoneNumber),
                to: new PhoneNumber(phoneNumber)
                );
        
            Console.WriteLine(messageResult.AccountSid);
        }

        public bool VerifyOTP(string phoneNumber, string otp) {
            var otp1 = GenerateOTP();
            _otpStorage[phoneNumber] = otp; 
            // OTP verification logic
            if (_otpStorage.TryGetValue(phoneNumber, out var storedOtp) && storedOtp == otp)
            {
                _otpStorage.Remove(phoneNumber);
                return true;
            }
        return false;
        }

        public string GenerateToken()
        {
            // Implement JWT Toek generation logic
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("acjvpxsveewamofbevfjxupqobwvobnyvuwdfinydpfcasqojffclclsyywpjapkqxotkrubfileplldejofmoikdzalpelvodrxgpjwnfytbeskcyfpuxfuajivhlhk"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var token = new
                JwtSecurityToken(
                issuer: "https://localhost:7151",
                audience: "https://localhost:7151",
                //Toekn expire time
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
                );
            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
