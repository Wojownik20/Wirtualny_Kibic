namespace Wirtualny_Kibic.Entities;

public class FormationPlan
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty; 

    public string Formation { get; set; } = string.Empty;

    public int TeamId { get; set; }
    public Team Team { get; set; }

    public string CreatedByUserId { get; set; }

    public ICollection<FormationPlayer> FormationPlayers { get; set; } = new List<FormationPlayer>();
}