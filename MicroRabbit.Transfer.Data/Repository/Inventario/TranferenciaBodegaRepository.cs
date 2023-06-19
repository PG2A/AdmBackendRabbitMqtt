using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class TranferenciaBodegaRepository : ITranfrenciaBodegaRepository
    {
        private readonly TablasContext _tablasContext;
     //   private readonly TablasSinKeyDbContext _tablasSinKeyDbContext;

        public TranferenciaBodegaRepository(TablasContext tablasContext, TablasSinKeyDbContext tablasSinKeyDbContext)
        {
            _tablasContext = tablasContext;
         //   _tablasSinKeyDbContext = tablasSinKeyDbContext;
        }

        public void ActualizarInventario(InvProductoBodegaTabla invproducto)
        {
            int producto = invproducto.Producto;
            int bodega = invproducto.Bodega;
            string lote = invproducto.Lote;
            //bool existe = _tablasSinKeyDbContext.INV_PRODUCTO_BODEGA.Any(p=> p.Producto == producto && p.Bodega == bodega && p.Lote == lote);

            var ejecutarSp = _tablasContext.Database.ExecuteSqlInterpolated($"EXEC SumarStockProducto {producto} {invproducto.Stock} {lote} {bodega} ");
            Console.WriteLine( ejecutarSp );    
            
        
        }

        public void Grabar(VenCabEgresoTabla vencabegreso)
        {
            _tablasContext.Add(vencabegreso);
            _tablasContext.SaveChanges();
        }

        public void GrabarDetalle(VenDetEgresoTabla vendetegreso)
        {
            _tablasContext.Add(vendetegreso);
            _tablasContext.SaveChanges();
        }
    }
}
