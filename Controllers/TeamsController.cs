using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Wirtualny_Kibic.Data;
using Wirtualny_Kibic.DTOs;
using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TeamsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
    {
        var teams = await _context.Teams.ToListAsync();
        return Ok(teams);
    }

    [HttpPost]
    public async Task<ActionResult<Team>> CreateTeam(Team team)
    {
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTeams), new { id = team.Id }, team);
    }

    [Authorize]
    [HttpGet("secure")]
    public IActionResult GetSecureTeams()
    {
        return Ok("You are authenticated!");
    }

    [HttpGet("my-team")]
    public async Task<ActionResult<TeamDto>> GetMyTeam()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var team = await _context.Teams
            .FirstOrDefaultAsync(t => t.Id == staff.TeamId);

        if (team == null)
            return NotFound();

        var playersCount = await _context.Players
            .CountAsync(p => p.TeamId == team.Id);

        var injuredPlayersCount = await _context.Players
            .CountAsync(p => p.TeamId == team.Id && p.InjuryStatus != null && p.InjuryStatus != "");

        var teamDto = new TeamDto
        {
            Id = team.Id,
            TeamName = team.Name,
            Stadium = team.Stadium,
            PlayersCount = playersCount,
            InjuredPlayersCount = injuredPlayersCount
        };

        return Ok(teamDto);
    }

}