
using Migration2.Models;
using Microsoft.EntityFrameworkCore;
using Migration2.Data;

namespace Migration2
{
    public class ProgramTesting
    {
        public static void MainB(string[] args) //rename to Main
        {
            Console.WriteLine("Starting like a Web API");
            Console.WriteLine("CurrentDir:" + Directory.GetCurrentDirectory());

            var builder = WebApplication.CreateBuilder(args);
            
            string connString = builder.Configuration["ConnectionStrings:DefaultConnection3"];
            Console.WriteLine("conn:" + connString);
            //var log = builder.Logging;
            //log.AddConsole();
 
            DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //optionsBuilder.UseSqlServer(connString);
            optionsBuilder.UseSqlite(connString);
            optionsBuilder.LogTo(Console.WriteLine);

            var context = new Migration2.Data.AppDbContext(optionsBuilder.Options);

            Aluno aluno = new Aluno
            {
                Nome = "ee",
                Idade = 18,
                Ativo = true
            };
            context.Add(aluno);
            context.SaveChanges();

            var list = context.Alunos
                //    .AsNoTracking()  ///?!?!
                //    .Where(x => x.Idade < 50)
                //    .Select(x => new { Id= x.Id, Nome = x.Nome})
                .ToList();
            
            context.Database.CloseConnection();
            context.Dispose();

            Console.WriteLine("========================================================================");
            foreach (var row in list)
            {
                Console.WriteLine(row.Id.ToString() + "|" + row.Nome +  "|" + row.Idade.ToString());
            }
            Console.WriteLine("========================================================================");
        }
    }
}


//var builder = WebApplication.CreateBuilder(args);
//string connString = builder.Configuration["ConnectionStrings:DefaultConnection3"]; //V1

//var app = builder.Build(); //V2
//string connString = app.Configuration.GetSection("ConnectionStrings:DefaultConnection3").Value; //V2

//V3
//var config = new ConfigurationBuilder()
////.SetBasePath(Directory.GetCurrentDirectory())
//.AddJsonFile("appsettings.json", optional: false)
//.Build();
//string connString = config.GetSection("ConnectionStrings:DefaultConnection3").Value;


////example 
//DbContextOptionsBuilder<AppDbContext> optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
////optionsBuilder.UseSqlServer(connString);
//optionsBuilder.UseSqlite(connString);
//optionsBuilder.LogTo(Console.WriteLine); //log sql

//var context = new Migration2.Data.AppDbContext(optionsBuilder.Options);
//var list = context.Alunos
//    .AsNoTracking()  ///?!?!
//    .Where(x => x.Idade < 50)
//    .Select(x => new { Id= x.Id, Nome = x.Nome})
//    .ToList();
//context.Dispose()