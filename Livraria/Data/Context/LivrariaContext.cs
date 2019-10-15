using Livraria.Data.Mapping;
using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data.Context
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext(DbContextOptions<LivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
