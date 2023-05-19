using MicroRabbit.Banking.Application.Models.CuentasPorPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar
{
    public interface IProveedorServices
    {
        void Enviar(ProveedorFarmaciaModel proveedor);
        void Editar(ProveedorFarmaciaModel proveedor);
        void Eliminar(ProveedorFarmaciaModel proveedor);
    }
}
