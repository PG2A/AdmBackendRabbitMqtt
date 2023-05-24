using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Contabilidad;
using MicroRabbit.Transfer.Domain.Models.Contabilidad;

namespace MicroRabbit.Transfer.Data.Repository.Contabilidad
{
    public class CuentaContableRepository : ICuentaContableRepository
    {
        private TablasContext _tablasContext;

        public CuentaContableRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void EditarTabla(CuentaContableTabla cuentacontable)
        {
            _tablasContext.Update(cuentacontable);
            _tablasContext.SaveChanges();
        }

        public void EliminarTabla(CuentaContableTabla cuentacontable)
        {
            _tablasContext.Remove(cuentacontable);
            _tablasContext.SaveChanges();
        }

        public void GrabarTabla(CuentaContableTabla cuentacontable)
        {
            _tablasContext.Add(cuentacontable);
            _tablasContext.SaveChanges();
        }
    }
}
