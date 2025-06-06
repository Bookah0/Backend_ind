using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Backend_ind.Models;
using Microsoft.AspNetCore.Identity;

public class UserService
{
    private readonly UserManager<UserEntity> userManager;

    public UserService(UserManager<UserEntity> userManager)
    {
        this.userManager = userManager;
    }

    public async Task RegisterUser(RegisterUserRequest request)
    {
        var user = new UserEntity(request.Username, request.Email);
        var result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            throw new Exception();
        }

        await userManager.AddToRoleAsync(user, "user");
    }

    public async Task Login(LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
        {
            throw new Exception("Must input a username");
        }

        if (string.IsNullOrWhiteSpace(request.Password))
        {
            throw new Exception("Must input a password");
        }
    }
}

public class LoginRequest
{
    [Required]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }
}

public class RegisterUserRequest
{
    [Required]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    
}