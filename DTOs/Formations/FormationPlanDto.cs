namespace Wirtualny_Kibic.DTOs.Formations;

public class FormationPlanDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Formation { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public List<FormationPlayerDto> Players { get; set; } = new();
}