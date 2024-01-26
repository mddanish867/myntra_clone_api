using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myntra_clone_api.Services;
using Twilio.TwiML.Messaging;

namespace myntra_clone_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("generate-otp/{phoneNumber}")]
        public IActionResult GenerateOTP(string phonNumber)
        {
            var otp = _authService.GenerateOTP();
            _authService.SendOTPViaSMS(phonNumber, otp);
            // Insert otp into _storedOtp
            
            return Ok(new
            {
                Message = "OTP sent successfully"
            });
        }

        [HttpPost("verify_otp/{phoneNumber}/{otp}")]
        public IActionResult VerifyOTP(string phoneNumber, string otp)
        {
            if (_authService.VerifyOTP(phoneNumber, otp))
            {
                var token = _authService.GenerateToken();
                return Ok(new
                {
                    Token = token
                });
            }
            return BadRequest(new
            {
                Message = "Invalid OTP"
            });
            
        }

        
    }
}
