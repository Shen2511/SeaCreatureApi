// W pliku Program.cs
using Microsoft.EntityFrameworkCore;
using SeaCreatureApi.Data;
using SeaCreatureApi.Models; // <-- Додали using

var builder = WebApplication.CreateBuilder(args);

// 1. Додаємо сервіси
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 2. Додаємо CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// 3. Додаємо тестові дані (Seeding)
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();

    if (!context.SeaCreatures.Any()) // Перевіряємо SeaCreatures
    {
        context.SeaCreatures.AddRange(
            new SeaCreature
            {
                Name = "Great White Shark",
                Lifespan = 30,
                DietType = "Carnivore", // Хижак
                Habitat = "Atlantic Ocean"
            },
            new SeaCreature
            {
                Name = "Sea Turtle",
                Lifespan = 80,
                DietType = "Herbivore", // Травоїдна
                Habitat = "Pacific Ocean"
            },
            new SeaCreature
            {
                Name = "Clownfish",
                Lifespan = 6,
                DietType = "Omnivore", // Всеїдна
                Habitat = "Indian Ocean"
            }
        );
        context.SaveChanges();
    }
}

// 4. Налаштовуємо Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); // <-- Вмикаємо CORS

app.UseAuthorization();

app.MapControllers();

app.Run();