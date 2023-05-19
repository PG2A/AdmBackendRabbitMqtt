using MicroRabbit.Transfer.Domain.Models.Inventario;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbit.Transfer.Data.Context
{
    public class TablasSinKeyDbContext : DbContext
    {
        public TablasSinKeyDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<InvProductoBodegaTabla> INV_PRODUCTO_BODEGA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvProductoBodegaTabla>().HasKey(e => e.Bodega).HasAnnotation("Keyless", true);
        }
    }
}
