using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Contabilidad;
using MicroRabbit.Transfer.Domain.Models.Contabilidad;

namespace MicroRabbit.Transfer.Data.Repository.Contabilidad
{
    public class BancoCiaRepository : IBancoCiaRepository
    {
        private TablasContext _tablasContext;

        public BancoCiaRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void GrabarTabla(BancoCiaTabla bancociaTabla)
        {
            _tablasContext.Add(bancociaTabla);
            _tablasContext.SaveChanges();
        }
    }
}
