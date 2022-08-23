using Microsoft.EntityFrameworkCore;
using PruebaTropigasAPI.Models;

namespace PruebaTropigasAPI.Context
{
    public class TropigasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:tropigas-lopezdb.database.windows.net,1433;Initial Catalog=ventasdb;Persist Security Info=False;User ID=dbadmintropigas;Password=Adm12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //modelos
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<VentaD> VentaD { get; set; }
    }
}
