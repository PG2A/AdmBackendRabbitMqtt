using MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar;
using Microsoft.EntityFrameworkCore;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using MicroRabbit.Transfer.Domain.Models.Contabilidad;
using MicroRabbit.Transfer.Domain.Models.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TablasContext : DbContext
    {
        public TablasContext(DbContextOptions<TablasContext> options) : base(options)
        {
        }
        public DbSet<Nivel1Tabla> INV_NIVEL_1 { get; set; }
        public DbSet<ClientesTabla> CXC_CLIENTE { get; set; }
        public DbSet<ProductosTabla> INV_PRODUCTO { get; set; }
        public DbSet<Nivel2Tabla> INV_NIVEL_2 { get; set; }
        public DbSet<Nivel3Tabla> INV_NIVEL_3 { get; set;}
        public DbSet<CamionTabla> INV_CAMION { get; set; }
        public DbSet<ChoferTabla> INV_CHOFER { get; set; }
        public DbSet<ProveedorTabla> CXP_PROVEEDOR { get; set; }
        public DbSet<PersonaTabla> ADM_PERSONA { get; set; }
        public DbSet<BancoCiaTabla> CNT_BANCOCIA { get; set; }
        public DbSet<VenCabEgresoTabla> VEN_CABEGRESO { get; set; }
        public DbSet<VenDetEgresoTabla> VEN_DETEGRESO { get; set; }
        public DbSet<VenCabEgresoBodTabla> VEN_CABEGRESO_BOD { get; set; }
        public DbSet<VenDetEgresoBodTabla> VEN_DETEGRESO_BOD { get; set; }
        public DbSet<MotivosInventarioTabla> INV_MOTIVO_MOVIMIENTO { get; set; }
        public DbSet<CuentaContableTabla> CNT_CUENTA_CONTABLE { get; set; }
        public DbSet<PrecioTabla> ADM_PRECIO { get; set; }
        public DbSet<VenCabingresoTabla> VEN_CABINGRESO { get; set; }
        public DbSet<VenDetingresoTabla> VEN_DETINGRESO { get; set; }
        public DbSet<VenCabingresoBodTabla> VEN_CABINGRESO_BOD { get; set; }
        public DbSet<VenDetingresoBodTabla> VEN_DETINGRESO_BOD { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=192.168.0.70;Initial Catalog=BDADMEP;user id=BIROBID;password=IROBID20");

        //}
    }
}
