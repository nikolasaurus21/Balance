using Balance.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetoore/swashbuckle

builder.Services.AddDbContext<MoneyBalanceContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("MoneyBalanceCOntext") 
    ?? throw new InvalidOperationException("Connection string 'MoneyBalanceContext' not found.")));

builder.Services.AddSingleton<MoneyBalance>();


builder.Services.AddEndpointsApiExplorer();
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
