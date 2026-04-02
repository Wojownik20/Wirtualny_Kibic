namespace Wirtualny_Kibic.DTOs.Formations;

public class CreateFormationPlanDto
{
    public string Name { get; set; } = string.Empty;
    public string Formation { get; set; } = string.Empty;
    public List<CreateFormationPlayerDto> Players { get; set; } = new();
}