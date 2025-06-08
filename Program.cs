using Backend_ind.Data;
using Backend_ind.Interfaces;
using Backend_ind.Models;
using Backend_ind.Repositories;
using Backend_ind.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddControllers();

builder.Services.AddScoped<IRepository<FileEntity>, EfRepository<FileEntity>>();
builder.Services.AddScoped<IRepository<FolderEntity>, EfRepository<FolderEntity>>();
builder.Services.AddScoped<FolderService>();
builder.Services.AddScoped<FileService>();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.Run();