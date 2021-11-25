
///////////////////////////////////
//Top-level statements  (concept)
///////////////////////////////////

using Microsoft.EntityFrameworkCore;
using Migration2.Data;

//dotnet ef migrations add myInitialCreation
//dotnet ef database update

Console.WriteLine("Starting like a Wrb API");

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration["ConnectionStrings:DefaultConnection3"];

builder.Services.AddDbContext<AppDbContext>(
    options => {
        options.UseSqlite(connString);
        options.LogTo(Console.WriteLine);
    }
);

var app = builder.Build();

app.Run();
