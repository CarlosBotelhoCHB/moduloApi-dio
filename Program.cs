using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*
    CONFIGURANDO A CONEXÃO COM O BANCO DE DADOS

    Estamos adicionando um DbContext do tipo AgendaContext e passando algumas opções:
    AgendaContext usa o Sql Server. 
    builder.configuration - Pegando a configuração do `appsettings.json`
    GetConnectionString - Pega a chave da conexão string e o nome da conexão (ConexãoPadrão)
*/
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
