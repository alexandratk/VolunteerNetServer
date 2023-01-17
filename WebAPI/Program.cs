using AutoMapper;
using BLL;
using BLL.Infrastructure;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

BusinessLogicLayerConfigurator.ConfigureServices(builder.Services);

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new BLL.Helpers.AutomapperProfile());
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VolunteerNetServerDBContext>(options =>
    //options.UseSqlServer(@"Server=localhost;Database=VolunteerNet;Trusted_Connection=True;"));
    options.UseSqlServer(@"Server=host.docker.internal,1435;Database=VolunteerNet;User Id=SA;Password=2Secure*Password2;"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.MapControllers();

app.Run();
