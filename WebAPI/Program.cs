using AutoMapper;
using BLL;
using BLL.Infrastructure;
using BLL.Interfaces;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using BLL.Helpers;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Hubs;
using BLL.BackgroundServices;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);

BusinessLogicLayerConfigurator.ConfigureServices(builder.Services);

var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new BLL.Helpers.AutomapperProfile());
});

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<VolunteerNetServerDBContext>(options =>
//options.UseSqlServer(@"Server=localhost,1435;Database=VolunteerNet;User Id=alex;Password=2Secure*Password2;"));
options.UseSqlServer(builder.Configuration.GetConnectionString("SQLDb")));
//options.UseSqlServer(@"Server=host.docker.internal,1435;Database=VolunteerNet;User Id=SA;Password=MySecurePassword*19*5;"));

builder.Services.AddSignalR();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                // specifies whether the publisher will be validated when validating the token
                ValidateIssuer = true,
                // a string representing the publisher
                ValidIssuer = AuthOptions.ISSUER,

                // whether the consumer of the token will be validated
                ValidateAudience = true,
                // setting consumer token
                ValidAudience = AuthOptions.AUDIENCE,
                // whether lifetime will be validated
                ValidateLifetime = true,

                // security key setting
                IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                // security key validation
                ValidateIssuerSigningKey = true,
            };
        });



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

//app.UseHttpsRedirection();

app.UseRouting();


app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapHub<ChatHub>("/hubs/chat");
});

app.MapControllers();

app.Run();
