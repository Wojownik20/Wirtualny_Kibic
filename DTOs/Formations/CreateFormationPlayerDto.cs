namespace Wirtualny_Kibic.DTOs.Formations;

public class CreateFormationPlayerDto
{
    public int PlayerId { get; set; }
    public string RolePosition { get; set; } = string.Empty;
}