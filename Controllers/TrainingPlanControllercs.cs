using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Wirtualny_Kibic.Data;
using Wirtualny_Kibic.Entities;
using Wirtualny_Kibic.DTOs.TrainingPlan;

[Route("api/[controller]")]
[ApiController]
public class TrainingPlansController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TrainingPlansController(ApplicationDbContext context)
    {
        _context = context;
    }

    private async Task<StaffProfile?> GetCurrentStaffAsync()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        return await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> CreateTrainingPlan(CreateTrainingPlanDto dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var plan = new TrainingPlan
        {
            Name = dto.Name,
            Description = dto.Description,
            Date = dto.Date,
            TeamId = staff.TeamId,
            Exercises = dto.Exercises?.Select(e => new TrainingExercise
            {
                Name = e.Name,
                Description = e.Description,
                DurationMinutes = e.DurationMinutes
            }).ToList() ?? new List<TrainingExercise>()
        };

        _context.TrainingPlans.Add(plan);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            plan.Id,
            plan.Name,
            plan.Description,
            plan.Date,
            plan.TeamId,
            Exercises = plan.Exercises.Select(e => new
            {
                e.Id,
                e.Name,
                e.Description,
                e.DurationMinutes
            })
        });
    }

    [Authorize]
    [HttpGet("my-team")]
    public async Task<IActionResult> GetMyTeamTrainingPlans()
    {
        var staff = await GetCurrentStaffAsync();

        if (staff == null)
            return Unauthorized();

        var plans = await _context.TrainingPlans
            .Where(tp => tp.TeamId == staff.TeamId)
            .Include(tp => tp.Exercises)
            .Select(tp => new
            {
                tp.Id,
                tp.Name,
                tp.Description,
                tp.Date,
                tp.TeamId,
                Exercises = tp.Exercises.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Description,
                    e.DurationMinutes
                })
            })
            .ToListAsync();

        return Ok(plans);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTrainingPlanById(int id)
    {
        var staff = await GetCurrentStaffAsync();

        if (staff == null)
            return Unauthorized();

        var plan = await _context.TrainingPlans
            .Where(tp => tp.Id == id && tp.TeamId == staff.TeamId)
            .Include(tp => tp.Exercises)
            .Select(tp => new
            {
                tp.Id,
                tp.Name,
                tp.Description,
                tp.Date,
                tp.TeamId,
                Exercises = tp.Exercises.Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Description,
                    e.DurationMinutes
                })
            })
            .FirstOrDefaultAsync();

        if (plan == null)
            return NotFound("Training plan not found.");

        return Ok(plan);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTrainingPlan(int id, UpdateTrainingPlanDto dto)
    {
        var staff = await GetCurrentStaffAsync();

        if (staff == null)
            return Unauthorized();

        var plan = await _context.TrainingPlans
            .Include(tp => tp.Exercises)
            .FirstOrDefaultAsync(tp => tp.Id == id && tp.TeamId == staff.TeamId);

        if (plan == null)
            return NotFound("Training plan not found.");

        plan.Name = dto.Name;
        plan.Description = dto.Description;
        plan.Date = dto.Date;

        _context.TrainingExercises.RemoveRange(plan.Exercises);

        plan.Exercises = dto.Exercises.Select(e => new TrainingExercise
        {
            Name = e.Name,
            Description = e.Description,
            DurationMinutes = e.DurationMinutes
        }).ToList();


        await _context.SaveChangesAsync();

        return Ok(new
        {
            plan.Id,
            plan.Name,
            plan.Description,
            plan.Date,
            plan.TeamId,
            Exercises = plan.Exercises.Select(e => new
            {
                e.Id,
                e.Name,
                e.Description,
                e.DurationMinutes
            })
        });
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTrainingPlan(int id)
    {
        var staff = await GetCurrentStaffAsync();

        if (staff == null)
            return Unauthorized();

        var plan = await _context.TrainingPlans
            .Include(tp => tp.Exercises)
            .FirstOrDefaultAsync(tp => tp.Id == id && tp.TeamId == staff.TeamId);

        if (plan == null)
            return NotFound("Training plan not found.");

        _context.TrainingExercises.RemoveRange(plan.Exercises);
        _context.TrainingPlans.Remove(plan);

        await _context.SaveChangesAsync();

        return Ok(new { message = "Training plan deleted successfully." });
    }
}