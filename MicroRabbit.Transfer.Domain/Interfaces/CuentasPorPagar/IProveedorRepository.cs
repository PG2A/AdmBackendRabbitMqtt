using MicroRabbit.Transfer.Domain.Models.CuentasPorPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar
{
    public interface IProveedorRepository
    {
        void GrabarTabla(ProveedorTabla proveedorTabla);
    }
}
