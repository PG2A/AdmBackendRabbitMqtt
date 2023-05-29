using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Data.Repository.Parametros
{
    public class PrecioRepository : IPrecioRepository
    {
        private TablasContext _tablasContext;

        public PrecioRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void EditarTabla(PrecioTabla precioTabla)
        {
            _tablasContext.Update(precioTabla);
            _tablasContext.SaveChanges();
        }

        public void GrabarTabla(PrecioTabla precioTabla)
        {
            _tablasContext.Add(precioTabla);
            _tablasContext.SaveChanges();
        }
    }
}
