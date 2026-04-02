namespace Wirtualny_Kibic.Entities;

public class FormationPlayer
{
    public int Id { get; set; }

    public int FormationPlanId { get; set; }
    public FormationPlan FormationPlan { get; set; }

    public int PlayerId { get; set; }
    public Player Player { get; set; }

    public string RolePosition { get; set; } = string.Empty;
}