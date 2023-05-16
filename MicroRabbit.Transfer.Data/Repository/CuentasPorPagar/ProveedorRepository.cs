using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository.CuentasPorPagar
{
    public class ProveedorRepository : IProveedorRepository
    {
        private TablasContext _tablasContext;
        public ProveedorRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void GrabarTabla(ProveedorTabla proveedor)
        {
            _tablasContext.Add(proveedor);
            _tablasContext.SaveChanges();
        }
    }
}
