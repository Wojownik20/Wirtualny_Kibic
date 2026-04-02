namespace Wirtualny_Kibic.DTOs.TrainingPlan;
public class UpdateTrainingPlanDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public List<UpdateTrainingExerciseDto> Exercises { get; set; }
}