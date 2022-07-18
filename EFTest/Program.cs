using AutoMapper;
using EFTest.Models;
using EFTest.Profiles;
using EFTest.ViewModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFTestDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFTestDB"));
});


builder.Services.AddAutoMapper(typeof(PageProfile));
//builder.Services.AddAutoMapper(config =>
//{
//    config.AddProfile<PageProfile>();
//});


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
