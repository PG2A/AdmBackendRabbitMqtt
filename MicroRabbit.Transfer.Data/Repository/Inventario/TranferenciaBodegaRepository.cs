using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class TranferenciaBodegaRepository : ITranfrenciaBodegaRepository
    {
        private readonly TablasContext _tablasContext;
        private readonly TablasSinKeyDbContext _tablasSinKeyDbContext;

        public TranferenciaBodegaRepository(TablasContext tablasContext, TablasSinKeyDbContext tablasSinKeyDbContext)
        {
            _tablasContext = tablasContext;
            _tablasSinKeyDbContext = tablasSinKeyDbContext;
        }

        public void ActualizarInventario(InvProductoBodegaTabla invproducto)
        {
            throw new NotImplementedException();
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
