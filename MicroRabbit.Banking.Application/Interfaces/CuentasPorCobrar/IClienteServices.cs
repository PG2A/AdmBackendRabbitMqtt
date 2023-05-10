using MicroRabbit.Banking.Application.Models.CuentasPorCobrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar
{
    public interface IClienteServices
    {
        void Enviar(ClienteModel cliente);
    }
}
