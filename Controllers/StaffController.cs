using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wirtualny_Kibic.Data;

namespace Wirtualny_Kibic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StaffController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public StaffController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetMyProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var profile = await _context.StaffProfiles
            .Include(s => s.Team)
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (profile == null)
            return NotFound("Staff profile not found.");

        return Ok(new
        {
            profile.FirstName,
            profile.LastName,
            profile.Role,
            Team = profile.Team.Name
        });
    }
}