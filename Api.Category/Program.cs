using Api.Category.Business;
using Api.Category.Helpers;
using Api.Category.Infrastructure;
using Api.Category.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Repository;
using Shared.Service;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration["ConnectionString"];
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CategoryDbContext>(o => o.UseSqlServer(connStr));
builder.Services.AddAutoMapper(typeof(Mapping));

#region DI

builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();

#endregion

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
