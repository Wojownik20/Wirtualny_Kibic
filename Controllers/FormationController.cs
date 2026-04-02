using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using Wirtualny_Kibic.Data;
using Wirtualny_Kibic.DTOs;
using Wirtualny_Kibic.DTOs.Formations;
using Wirtualny_Kibic.DTOs.TrainingPlan;
using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class FormationsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public FormationsController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpPost]
    public async Task<IActionResult> CreateFormation(CreateFormationPlanDto dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var formationPlan = new FormationPlan
        {
            Name = dto.Name,
            Formation = dto.Formation,
            TeamId = staff.TeamId,
            CreatedByUserId = userId!
        };

        _context.FormationPlans.Add(formationPlan);
        await _context.SaveChangesAsync();

        foreach (var playerDto in dto.Players)
        {
            var playerExists = await _context.Players
                .AnyAsync(p => p.Id == playerDto.PlayerId && p.TeamId == staff.TeamId);

            if (!playerExists)
                return BadRequest($"Player with ID {playerDto.PlayerId} does not belong to your team.");

            var formationPlayer = new FormationPlayer
            {
                FormationPlanId = formationPlan.Id,
                PlayerId = playerDto.PlayerId,
                RolePosition = playerDto.RolePosition
            };

            _context.FormationPlayers.Add(formationPlayer);
        }

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Formation plan created successfully",
            formationPlanId = formationPlan.Id
        });
    }

    [HttpGet("my-team")]
    public async Task<ActionResult<IEnumerable<FormationPlanDto>>> GetMyTeamFormations()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized("Brak userId w tokenie.");

        var staffProfile = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staffProfile == null)
            return NotFound("Nie znaleziono profilu staff dla zalogowanego użytkownika.");

        var formations = await _context.FormationPlans
            .Where(f => f.TeamId == staffProfile.TeamId)
            .Include(f => f.FormationPlayers)
                .ThenInclude(fp => fp.Player)
            .ToListAsync();

        var result = formations.Select(f => new FormationPlanDto
        {
            Id = f.Id,
            Name = f.Name,
            Formation = f.Formation,
            Players = f.FormationPlayers.Select(fp => new FormationPlayerDto
            {
                PlayerId = fp.PlayerId,
                PlayerName = fp.Player.FirstName + " " + fp.Player.LastName,
                RolePosition = fp.RolePosition
            }).ToList()
        }).ToList();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FormationPlanDto>> GetFormationById(int id)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized("Brak userId w tokenie.");

        var staffProfile = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staffProfile == null)
            return NotFound("Nie znaleziono profilu staff dla zalogowanego użytkownika.");

        var formation = await _context.FormationPlans
            .Where(f => f.Id == id && f.TeamId == staffProfile.TeamId)
            .Include(f => f.FormationPlayers)
                .ThenInclude(fp => fp.Player)
            .FirstOrDefaultAsync();

        if (formation == null)
            return NotFound("Nie znaleziono formacji dla tej drużyny.");

        var result = new FormationPlanDto
        {
            Id = formation.Id,
            Name = formation.Name,
            Formation = formation.Formation,
            Players = formation.FormationPlayers.Select(fp => new FormationPlayerDto
            {
                PlayerId = fp.PlayerId,
                PlayerName = fp.Player.FirstName + " " + fp.Player.LastName,
                RolePosition = fp.RolePosition
            }).ToList()
        };

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFormation(int id)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (string.IsNullOrEmpty(userId))
            return Unauthorized("Brak userId w tokenie.");

        var staffProfile = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staffProfile == null)
            return NotFound("Nie znaleziono profilu staff dla zalogowanego użytkownika.");

        var formation = await _context.FormationPlans
            .Include(f => f.FormationPlayers)
            .FirstOrDefaultAsync(f => f.Id == id && f.TeamId == staffProfile.TeamId);

        if (formation == null)
            return NotFound("Nie znaleziono formacji dla tej drużyny.");

        _context.FormationPlayers.RemoveRange(formation.FormationPlayers);
        _context.FormationPlans.Remove(formation);

        await _context.SaveChangesAsync();

        return Ok(new { message = "Formation deleted successfully." });
    }


}

