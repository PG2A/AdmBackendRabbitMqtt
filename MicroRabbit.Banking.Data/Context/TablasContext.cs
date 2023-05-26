using MicroRabbit.Banking.Data.Tablas;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbit.Banking.Data.Context
{
    public class TablasContext : DbContext
    {
        public TablasContext(DbContextOptions<TablasContext> options) : base(options)
        {
        }
        public DbSet<SucursalTabla> ADM_SUCURSAL { get; set; }


    }
}
