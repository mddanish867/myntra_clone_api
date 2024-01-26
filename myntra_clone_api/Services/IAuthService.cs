namespace myntra_clone_api.Services
{
    public interface IAuthService
    {
        string GenerateOTP();
        void SendOTPViaSMS(string phoneNumber, string otp);
        bool VerifyOTP(string phoneNumber, string otp);
        string GenerateToken();
    }
}
