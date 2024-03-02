namespace myntra_clone_api.Services
{
    public interface IAuthService
    {
        string GenerateOTP();
        string SendOTPViaSMS(string phoneNumber, string otp);
        bool VerifyOTP(string phoneNumber, string otp);
        string GenerateToken(string phoneNumber);
    }
}
