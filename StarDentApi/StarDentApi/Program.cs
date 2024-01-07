using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using StarDentApi.Middlewares;
using StarDentApi.Repositories;
using StarDentApi.Repositories.Abstract;
using StarDentApi.Repositories.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped(typeof(IAccesstokenRepository), typeof(AccesstokenRepository));
builder.Services.AddScoped(typeof(IRoleprivilegeRepository), typeof(RoleprivilegeRepository));
builder.Services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));
builder.Services.AddScoped(typeof(ITablemetaconfigRepository), typeof(TablemetaconfigRepository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorizationMiddleware();

app.MapControllers();

app.Run();
