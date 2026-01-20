using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

using FivetoSeven.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<FiveToSeven.Services.MadLibService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<ReverseAlphaService>();
builder.Services.AddScoped<ReverseNumbersService>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
