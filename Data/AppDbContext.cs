using Backend_ind.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_ind.Data;

public class AppDbContext : DbContext {
    public DbSet<Models.File> Files { get; set; }
    public DbSet<Folder> Folders { get; set; }
    public DbSet<User> Users { get; set; }
}