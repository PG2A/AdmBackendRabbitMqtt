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
        public void EditarTabla(BancoCiaTabla bancociaTabla)
        {
            _tablasContext.Update(bancociaTabla);
            _tablasContext.SaveChanges();
        }
        public void EliminarTabla(BancoCiaTabla bancociaTabla)
        {
            _tablasContext.Remove(bancociaTabla);
            _tablasContext.SaveChanges();
        }
    }
}
