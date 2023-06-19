using MicroRabbit.Banking.Data.Tablas;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbit.Banking.Data.Context
{
    public class TablasContext : DbContext
    {

        public TablasContext(DbContextOptions<TablasContext> options) : base(options)
        {

        }

     
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=192.168.0.70;Initial Catalog=BDADMEP;user id=BIROBID;password=IROBID20");

        //}
        public DbSet<SucursalTabla> ADM_SUCURSAL { get; set; }

        public List<SucursalTabla> ObtenerTodasLasSucursales()
        {
            return ADM_SUCURSAL.ToList();
        }

        //public List<SucursalTabla> ListaSucursales() {
        //    List<SucursalTabla> productos = TablasContext.ADM_SUCURSAL.ToList();

        //    return productos;
        //};
    }
}
