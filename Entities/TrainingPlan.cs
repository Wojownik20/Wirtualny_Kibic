using Wirtualny_Kibic.Entities;

public class TrainingPlan
{
    public int Id { get; set; }

    public string Name { get; set; } 

    public string Description { get; set; }

    public DateTime Date { get; set; }

    public int TeamId { get; set; }
    public Team Team { get; set; }

    public List<TrainingExercise> Exercises { get; set; }
}