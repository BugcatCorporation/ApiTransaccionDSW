using ApiTransaccion.DbContexts;
using ApiTransaccion.Repositories;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var cadena = builder.Configuration.GetConnectionString("BugcatDB");
builder.Services.AddDbContext<BugcatDBContext>(options => { options.UseSqlServer(cadena); });

builder.Services.AddScoped<ITransaccionRepository, TransaccionRepository>();

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
