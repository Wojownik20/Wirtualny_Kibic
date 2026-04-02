using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Wirtualny_Kibic.Data;
using Wirtualny_Kibic.DTOs;


namespace Wirtualny_Kibic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PlayersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpGet("my-team")]
    public async Task<ActionResult<IEnumerable<PlayerDto>>> GetMyTeamPlayers()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var players = await _context.Players
            .Where(p => p.TeamId == staff.TeamId)
            .OrderBy(p => p.Number)
            .Select(p => new PlayerDto
            {
                Id = p.Id,
                Name = p.FirstName + " " + p.LastName,
                Number = p.Number,
                Position = p.Position,
                Age = p.Age,
                Nationality = p.Nationality,
                InjuryStatus = p.InjuryStatus,
                Notes = p.Notes
            })
            .ToListAsync();

        return Ok(players);
    }


    [Authorize]
    [HttpGet("{id}")]
    public async Task<ActionResult<PlayerDto>> GetPlayer(int id)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var player = await _context.Players
            .FirstOrDefaultAsync(p => p.Id == id && p.TeamId == staff.TeamId);

        if (player == null)
            return NotFound();

        var playerDto = new PlayerDto
        {
            Id = player.Id,
            Name = player.FirstName + " " + player.LastName,
            Number = player.Number,
            Position = player.Position,
            Age = player.Age,
            Nationality = player.Nationality,
            InjuryStatus = player.InjuryStatus,
            Notes = player.Notes
        };


        return Ok(playerDto);
    }

    [Authorize]
    [HttpPut("{id}/staff-data")]
    public async Task<IActionResult> UpdatePlayerStaffData(int id, UpdatePlayerStaffDto dto)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var staff = await _context.StaffProfiles
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (staff == null)
            return Unauthorized();

        var player = await _context.Players
            .FirstOrDefaultAsync(p => p.Id == id && p.TeamId == staff.TeamId);

        if (player == null)
            return NotFound();

        player.InjuryStatus = dto.InjuryStatus;
        player.Notes = dto.Notes;

        await _context.SaveChangesAsync();

        return NoContent();
    }





}