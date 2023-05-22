using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Models.CuentasPorPagar;

namespace MicroRabbit.Transfer.Data.Repository.CuentasPorPagar
{
    public class ProveedorRepository : IProveedorRepository
    {
        private TablasContext _tablasContext;
        public ProveedorRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void EditarTabla(ProveedorTabla proveedor)
        {
            _tablasContext.Update(proveedor);
            _tablasContext.SaveChanges();
        }

        public void GrabarTabla(ProveedorTabla proveedor)
        {
            _tablasContext.Add(proveedor);
            _tablasContext.SaveChanges();
        }
    }
}
