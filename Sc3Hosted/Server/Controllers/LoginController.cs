﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Sc3Hosted.Server.Entities;
using Sc3Hosted.Shared.Dtos;
namespace Sc3Hosted.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public LoginController(IConfiguration configuration,
        SignInManager<ApplicationUser> signInManager)
    {
        _configuration = configuration;
        _signInManager = signInManager;
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginDto login)
    {
        var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

        if (!result.Succeeded) return BadRequest(new LoginResultDto { Successful = false, Error = "Username and password are invalid." });

        var user = await _signInManager.UserManager.FindByEmailAsync(login.Email);
        var roles = await _signInManager.UserManager.GetRolesAsync(user);
        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, login.Email)
        };

        foreach (var role in roles)
            claims.Add(new Claim(ClaimTypes.Role, role));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

        var token = new JwtSecurityToken(
        _configuration["JwtIssuer"],
        _configuration["JwtAudience"],
        claims,
        expires: expiry,
        signingCredentials: creds
        );

        return Ok(new LoginResultDto { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
    }
}
