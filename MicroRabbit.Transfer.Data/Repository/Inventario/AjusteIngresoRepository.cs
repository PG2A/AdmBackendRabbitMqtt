using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class AjusteIngresoRepository : IAjusteIngresoRepository
    {

        private readonly TablasContext _tablasContext;

        public AjusteIngresoRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void ActualizarInventario(VenAgregarStockProductoBodAjusteIngresoProc invproducto)
        {
           // float Cantidad = invproducto.uni + (item.Caja * item.Factor)
            float cantidad = invproducto.Cantidad;
            int codigo = invproducto.Codigo;
            int bodega = invproducto.Bodega;
            string lote = invproducto.Lote;
            DateTime fechaela = invproducto.Fechaela;
            DateTime fechaven = invproducto.Fechaven;

            //bool existe = _tablasSinKeyDbContext.INV_PRODUCTO_BODEGA.Any(p=> p.Producto == producto && p.Bodega == bodega && p.Lote == lote);

            var ejecutarSp = _tablasContext.Database.ExecuteSqlInterpolated($"EXEC VenAgregarStockProductoBodAjusteIngreso {cantidad}, {codigo}, {lote}, {bodega}, {fechaela}, {fechaven} ");
            Console.WriteLine(ejecutarSp);
        }

        public void Grabar(VenCabingresoTabla vencabegreso)
        {
            _tablasContext.Add(vencabegreso);
            _tablasContext.SaveChanges();
        }

        public void GrabarBod(VenCabingresoBodTabla vencabegreso)
        {
            _tablasContext.Add(vencabegreso);
            _tablasContext.SaveChanges();
        }

        public void GrabarDetalle(VenDetingresoTabla vendetegreso)
        {
            _tablasContext.Add(vendetegreso);
            _tablasContext.SaveChanges();
        }

        public void GrabarDetalleBod(VenDetingresoBodTabla vendetegreso)
        {
            _tablasContext.Add(vendetegreso);
            _tablasContext.SaveChanges();
        }
    }
}
