using FluentValidation;
using LinqLab.Domain.Repositories;
using LINQLab.Application;
using LINQLab.Application.Handlers;
using LINQLab.Application.Repositories;
using  LINQLab.Application.Repositories;
using LINQLab.Infrastructure.Persistence.InMemory;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ ثبت MediatR - این خط رو درست کن
//builder.Services.AddMediatR(typeof(CreateTaskHandler).Assembly);
//builder.Services.AddValidatorsFromAssembly(typeof(CreateTaskHandler).Assembly);

builder.Services.AddApplication();

// ثبت Repository ها
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<ITodoRepository, TodoRepository>();

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