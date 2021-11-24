using Microsoft.EntityFrameworkCore;
using Migration2.Models;

namespace Migration2.Data
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=mydb.sqlite;");
            options.LogTo(Console.WriteLine);
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
