using Pedalea.Api.Filtros;
using MediatR;
using System.Reflection;
using Pedalea.Infraestructura.Extensiones;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers(options => 
{
    options.Filters.Add(typeof(AppExceptionFilterAttribute));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.Load("Pedalea.Aplicacion"), typeof(Program).Assembly);
builder.Services.AddAutoMapper(Assembly.Load("Pedalea.Aplicacion"));

builder.Services.AgregarPersistenciaDatos(config);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Pedalea Api", Version = "v1" });
});

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
