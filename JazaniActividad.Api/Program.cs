using JazaniActividad.Application.Admins.Dtos.Currencies.Mappers;
using JazaniActividad.Application.Admins.Services;
using JazaniActividad.Application.Admins.Services.Implementations;

using JazaniActividad.Infrastructure.Admins.Persistences;
using JazaniActividad.Infrastructure.Cores.Contexts;
using JazaniActividad.Application.Cores.Contexts;
using JazaniActividad.Application.Cores.Contexts;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Infraestructure
builder.Services.addInfrastructureServices(builder.Configuration);



//Applications
//builder.Services.AddTransient<ICurrencyService, CurrencyService>();
builder.Services.AddApplicationServices();



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
