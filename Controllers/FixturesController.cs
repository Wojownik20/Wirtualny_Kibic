using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Wirtualny_Kibic.Data;
using Wirtualny_Kibic.Entities;
using Microsoft.Extensions.Options;

namespace Wirtualny_Kibic.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class FixturesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public FixturesController(ApplicationDbContext context)
    {
        _context = context;
    }
}