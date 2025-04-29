
using Microsoft.EntityFrameworkCore;
using ElectroCorhuila.Domain.Entities;

namespace ElectroCorhuila.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarifa>().HasData(
                new Tarifa { Id = 1, Estrato = 1, Valor = 1000 },
                new Tarifa { Id = 2, Estrato = 2, Valor = 1500 },
                new Tarifa { Id = 3, Estrato = 3, Valor = 2000 },
                new Tarifa { Id = 4, Estrato = 4, Valor = 3000 },
                new Tarifa { Id = 5, Estrato = 5, Valor = 4000 },
                new Tarifa { Id = 6, Estrato = 6, Valor = 5000 }
            );
        }
    }
}
