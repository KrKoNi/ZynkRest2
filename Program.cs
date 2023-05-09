using ZynkRest2.Models;
using ZynkRest2.Repositories;
using ZynkRest2.Repositories.Implementations;
using ZynkRest2.Services;
using ZynkRest2.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IRepository<Material>, MaterialRepo>();
builder.Services.AddScoped<IService<Material>, MaterialsService>();
builder.Services.AddScoped<IRepository<Sample>, SamplesRepo>();
builder.Services.AddScoped<IService<Sample>, SamplesService>();
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