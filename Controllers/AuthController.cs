using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Wirtualny_Kibic.DTOs._2FA;
using Wirtualny_Kibic.DTOs.Login;
using Wirtualny_Kibic.Entities;

namespace Wirtualny_Kibic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IConfiguration _configuration;

    public AuthController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        var existingUser = await _userManager.FindByEmailAsync(dto.Email);
        if (existingUser != null)
            return BadRequest("User with this email already exists.");

        var user = new ApplicationUser
        {
            UserName = dto.Email,
            Email = dto.Email
        };

        var result = await _userManager.CreateAsync(user, dto.Password);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok("User registered successfully.");
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequestDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return Unauthorized("Invalid email or password.");

        var passwordValid = await _userManager.CheckPasswordAsync(user, dto.Password);
        if (!passwordValid)
            return Unauthorized("Invalid email or password.");

        if (await _userManager.GetTwoFactorEnabledAsync(user))
        {
            return Ok(new LoginResponseDto
            {
                RequiresTwoFactor = true,
                Message = "Two-factor authentication required."
            });
        }

        var token = await GenerateJwtToken(user);
        return Ok(new LoginResponseDto
        {
            RequiresTwoFactor = false,
            Token = token
        });
    }

    [HttpPost("login-2fa")]
    public async Task<IActionResult> Login2Fa(Verify2FaLoginDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return Unauthorized("Invalid request.");

        if (!await _userManager.GetTwoFactorEnabledAsync(user))
            return BadRequest("2FA is not enabled for this account.");

        bool success = false;

        if (!string.IsNullOrWhiteSpace(dto.Code))
        {
            var code = dto.Code.Replace(" ", "").Replace("-", "");
            success = await _userManager.VerifyTwoFactorTokenAsync(
                user,
                _userManager.Options.Tokens.AuthenticatorTokenProvider,
                code
            );
        }
        else if (!string.IsNullOrWhiteSpace(dto.RecoveryCode))
        {
            success = await _userManager.RedeemTwoFactorRecoveryCodeAsync(user, dto.RecoveryCode) != null;
        }

        if (!success)
            return Unauthorized("Invalid 2FA code.");

        var token = await GenerateJwtToken(user);

        return Ok(new LoginResponseDto
        {
            RequiresTwoFactor = false,
            Token = token
        });
    }


    private Task<string> GenerateJwtToken(ApplicationUser user)
    {
        var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id),
        new Claim(ClaimTypes.Name, user.UserName ?? user.Email ?? string.Empty),
        new Claim(ClaimTypes.Email, user.Email ?? string.Empty)
    };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!)
        );

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: creds
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return Task.FromResult(jwt);
    }
}