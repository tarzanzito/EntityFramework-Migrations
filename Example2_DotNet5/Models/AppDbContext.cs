using Microsoft.EntityFrameworkCore;

namespace Migration2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        { }
        public DbSet<Aluno> Alunos { get; set; }

    }
}
