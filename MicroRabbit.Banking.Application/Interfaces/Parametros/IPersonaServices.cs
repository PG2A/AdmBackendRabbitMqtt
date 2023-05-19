using MicroRabbit.Banking.Domain.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Interfaces.Parametros
{
    public interface IPersonaServices
    {
        void Enviar(PersonaModel persona);
        void Editar(PersonaModel persona);
        void Eliminar(PersonaModel persona);
    }
}
