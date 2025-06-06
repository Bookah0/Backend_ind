namespace Backend_ind.Models;

public class UserEntity
{
    public required Guid Id { get; set; }
    public required string Username { get; set; }
    public required string Password { get; set; }
}