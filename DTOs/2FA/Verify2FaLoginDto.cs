namespace Wirtualny_Kibic.DTOs._2FA
{
    public class Verify2FaLoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string? RecoveryCode { get; set; }
    }
}
