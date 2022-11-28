using Lumory.Data;
using Lumory.Repositories.Companies;
using Lumory.Repositories.Users;
using Lumory.Services.Companies;
using Lumory.Services.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var serverVersion = new MySqlServerVersion(new Version(10, 9, 3));

builder.Services.AddDbContextPool<ApplicationDbContext>(dbContextOptions => dbContextOptions
    .UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), serverVersion)
    // The following three options help with debugging, but should
    // be changed or removed for production.
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CompanyRepository>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
