using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIDuvidas.Data;
using APIDuvidasXOportunidades.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<APIDuvidasXOportunidadesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIDuvidasXOportunidadesContext") ?? throw new InvalidOperationException("Connection string 'APIDuvidasXOportunidadesContext' not found.")));
builder.Services.AddDbContext<APIDuvidasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIDuvidasContext") ?? throw new InvalidOperationException("Connection string 'APIDuvidasContext' not found.")));

// Add services to the container.

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
