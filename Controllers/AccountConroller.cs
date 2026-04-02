using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wirtualny_Kibic.DTOs._2FA;
using Wirtualny_Kibic.Entities;

[ApiController]
[Route("api/[controller]")]
[Authorize] 
public class AccountController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AccountController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [Authorize]
    [HttpPost("2fa/setup")]
    public async Task<IActionResult> Setup2Fa()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized();

        await _userManager.ResetAuthenticatorKeyAsync(user);
        var key = await _userManager.GetAuthenticatorKeyAsync(user);

        if (string.IsNullOrEmpty(key))
            return BadRequest("Could not load authenticator key.");

        var email = await _userManager.GetEmailAsync(user);

        string issuer = "WirtualnyKibic";
        string authenticatorUri =
            $"otpauth://totp/{Uri.EscapeDataString(issuer)}:{Uri.EscapeDataString(email!)}" +
            $"?secret={key}&issuer={Uri.EscapeDataString(issuer)}&digits=6";

        return Ok(new
        {
            sharedKey = key,
            authenticatorUri = authenticatorUri
        });
    }

    [Authorize]
    [HttpPost("2fa/enable")]
    public async Task<IActionResult> Enable2Fa(Enable2FaDto dto)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized();

        var code = dto.Code.Replace(" ", "").Replace("-", "");

        var isValid = await _userManager.VerifyTwoFactorTokenAsync(
            user,
            _userManager.Options.Tokens.AuthenticatorTokenProvider,
            code
        );

        if (!isValid)
            return BadRequest("Invalid verification code.");

        await _userManager.SetTwoFactorEnabledAsync(user, true);

        var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);

        return Ok(new
        {
            message = "2FA enabled successfully.",
            recoveryCodes = recoveryCodes
        });
    }

    [Authorize]
    [HttpGet("2fa/status")]
    public async Task<IActionResult> Get2FaStatus()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized();

        return Ok(new
        {
            is2FaEnabled = await _userManager.GetTwoFactorEnabledAsync(user)
        });
    }

    [Authorize]
    [HttpPost("2fa/disable")]
    public async Task<IActionResult> Disable2Fa(Disable2FaDto dto)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized();

        var code = dto.Code.Replace(" ", "").Replace("-", "");

        var isValid = await _userManager.VerifyTwoFactorTokenAsync(
            user,
            _userManager.Options.Tokens.AuthenticatorTokenProvider,
            code
        );

        if (!isValid)
            return BadRequest("Invalid verification code.");

        await _userManager.SetTwoFactorEnabledAsync(user, false);

        return Ok(new { message = "2FA disabled successfully." });
    }

    [Authorize]
    [HttpPost("2fa/recovery-codes/regenerate")]
    public async Task<IActionResult> RegenerateRecoveryCodes()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return Unauthorized();

        if (!await _userManager.GetTwoFactorEnabledAsync(user))
            return BadRequest("2FA is not enabled.");

        var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);

        return Ok(new { recoveryCodes });
    }
}