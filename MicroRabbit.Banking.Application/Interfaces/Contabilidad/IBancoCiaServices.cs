using MicroRabbit.Banking.Application.Models.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces.Contabilidad
{
    public interface IBancoCiaServices
    {
        void Enviar(BancoCiaModel bancocia);
    }
}
