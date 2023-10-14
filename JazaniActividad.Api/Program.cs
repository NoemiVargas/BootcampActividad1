using JazaniActividad.Api.Filters;
using JazaniActividad.Application.Cores.Contexts;
using JazaniActividad.Core.Securities.Services.Implementations;
using JazaniActividad.Core.Securities.Services;
using JazaniActividad.Infrastructure.Cores.Contexts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// PasswordHasher
builder.Services.Configure<PasswordHasherOptions>(options =>
{
    options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3;
});

// ISecurityService
builder.Services.AddTransient<ISecurityService, SecurityService>();



//JWT
string jwtSecretKey = builder.Configuration.GetSection("Security:JwtSecrectKey").Get<string>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    byte[] key = Encoding.ASCII.GetBytes(jwtSecretKey);
    options.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateLifetime = true,
        ValidIssuer = "",
        ValidAudience = "",
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true
    };
});

// AuthorizeOperationFilter
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<AuthorizeOperationFilter>();

    string schemeName = "Bearer";
    options.AddSecurityDefinition(schemeName, new OpenApiSecurityScheme()
    {
        Name = schemeName,
        BearerFormat = "JWT",
        Scheme = "bearer",
        Description = "Add token.",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http
    });

});





// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Infraestructure
builder.Services.addInfrastructureServices(builder.Configuration);



//Applications
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
