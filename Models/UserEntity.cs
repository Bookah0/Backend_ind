using Microsoft.AspNetCore.Identity;

namespace Backend_ind.Models;

public class UserEntity : IdentityUser
{
    public UserEntity(string userName, string email) : base(userName)
    {
        Email = email;
        UserName = userName;
    }
}