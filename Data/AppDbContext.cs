using Backend_ind.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Backend_ind.Data;

public class AppDbContext : IdentityDbContext<UserEntity>
{
    public DbSet<FileEntity> Files { get; set; }
    public DbSet<FolderEntity> Folders { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}