using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Entity
{
    public class DataContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=frigosoft;user=root;password=")
            .EnableSensitiveDataLogging(true)
            .UseLoggerFactory(new LoggerFactory());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id);
            }); 
            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}
