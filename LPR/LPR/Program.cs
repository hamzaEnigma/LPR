using LPR.DAL.CoreDB;
using LPR.DAL.Interfaces.IRepositories;
using LPR.DAL.Repositories;
using LPR.Service.IServices;
using LPR.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LrpContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("myDb1")));
builder.Services.AddScoped<IProfesionnalRepository, ProfesionnalRepository>();
builder.Services.AddScoped<IProfesionnalService, ProfesionnalService>();
builder.Services.AddScoped<IDateRepository, DateRepository>();
builder.Services.AddScoped<IDateService, DateService>();
builder.Services.AddScoped<IHourRepository, HourRepository>();
builder.Services.AddScoped<IHourService, HourService>();

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
