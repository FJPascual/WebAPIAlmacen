using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebAPIAlmacen.Entidades;
using WebAPIAlmacen.Entidades.Seed;

namespace WebAPIAlmacen
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Familia>().HasKey(x => x.Id);
            //modelBuilder.Entity<Familia>().Property(x => x.Nombre).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Producto>().Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            ////modelBuilder.Entity<Producto>().Property(x => x.Precio).HasPrecision(precision:9, scale:2);
            ////modelBuilder.Entity<Producto>().Property(x => x.FechaAlta).HasColumnType("Date");
            //modelBuilder.Entity<Distribuidor>().Property(x => x.Nombre).HasMaxLength(150).IsRequired();
            //modelBuilder.Entity<DistribuidorProducto>().HasKey(x => new { x.DistribuidorId, x.ProductoId });
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData.Seed(modelBuilder);

        }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<UbicacionProducto> UbicacionesProductos { get; set; }
        public DbSet<Distribuidor> Distribuidores { get; set; }
        public DbSet<DistribuidorProducto> DistribuidoresProductos { get; set; }
    }
}
