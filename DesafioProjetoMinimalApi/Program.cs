using DesafioProjetoMinimalAPI.Infraesturura.Db;
using DesafioProjetoMinimalAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using DesafioProjetoMinimalAPI.Dominio.Interfaces;
using DesafioProjetoMinimalApi.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IAdministradorServico, AdministradorServico>();

builder.Services.AddDbContext<DbContexto>(options => {
    options.UseMySql(
        builder.Configuration.GetConnectionString("mysql"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", ([FromBody] DesafioProjetoMinimalAPI.DTOs.LoginDTO loginDTO, IAdministradorServico administradorServico) => {
    if (administradorServico.Login(loginDTO) != null)
    {
        return Results.Ok("Login com sucesso");
    }else{
        return Results.Unauthorized();
    }
});


app.Run();

