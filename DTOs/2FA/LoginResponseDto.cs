namespace Wirtualny_Kibic.DTOs._2FA
{
    public class LoginResponseDto
    {
        public bool RequiresTwoFactor { get; set; }
        public string? Token { get; set; }
        public string? Message { get; set; }
    }
}
