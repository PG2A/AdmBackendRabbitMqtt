using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Data.Repository.Parametros
{
    public class BodegaRepository : IBodegaRepository
    {
        private TablasContext _tablasContext;

        public BodegaRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public List<BodegaTabla> ObtenerRegistros()
        {
            var lista = _tablasContext.ADM_BODEGA.ToList();
            return lista;
        }
    }
}
