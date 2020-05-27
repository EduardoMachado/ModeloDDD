using Microsoft.EntityFrameworkCore;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Infra.Data.Map;

namespace ModeloDDD.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }

        public DbSet<Usuario> Products { get; set; }
    }
}
