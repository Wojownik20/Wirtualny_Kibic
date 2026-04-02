public class TrainingExercise
{
    public int Id { get; set; }

    public string Name { get; set; } 

    public string Description { get; set; }

    public int DurationMinutes { get; set; }

    public int TrainingPlanId { get; set; }
    public TrainingPlan TrainingPlan { get; set; }
}