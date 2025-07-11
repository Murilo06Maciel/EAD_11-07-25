using Microsoft.EntityFrameworkCore;
using MyAspNetCoreWebApp.Data; // Ajuste para o namespace correto do seu AppDbContext

var builder = WebApplication.CreateBuilder(args);

// Adiciona o serviço do banco de dados MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36)) // Ajuste a versão conforme seu MySQL
    )
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
