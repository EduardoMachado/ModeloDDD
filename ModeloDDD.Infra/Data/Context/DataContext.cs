using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.ValueObjects;
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
            modelBuilder.Ignore<Notification>();
            modelBuilder.Ignore<Email>();
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
