
using Migration2.Models;
using Microsoft.EntityFrameworkCore;
using Migration2.Data;
using Migration2;

namespace Migration2
{
    public class ProgramMain
    {
        public static void MainB(string[] args)
        {
            //dotnet ef migrations add myInitialCreation
            //dotnet ef database update

            Console.WriteLine("Starting like a Wrb API");

            var builder = WebApplication.CreateBuilder(args);

            string connString = builder.Configuration["ConnectionStrings:DefaultConnection3"];

            builder.Services.AddDbContext<AppDbContext>(
              options =>
              {
                  options.UseSqlite(connString);
                  options.LogTo(Console.WriteLine);
              }
              );

            var app = builder.Build();

            //not need for migration
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            //app.UseHttpsRedirection();

            app.Run();
        }
    }
}
