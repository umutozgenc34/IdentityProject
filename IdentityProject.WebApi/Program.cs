using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Models;
using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Repository.Abstracts.Concrates;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, EfUserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IRoleRepository,EfRoleRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<MsSqlContext>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
