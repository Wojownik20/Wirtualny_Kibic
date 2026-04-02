namespace Wirtualny_Kibic.DTOs.TrainingPlan;
public class CreateTrainingPlanDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }

    public List<CreateTrainingExerciseDto> Exercises { get; set; }
}