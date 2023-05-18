using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Domain.Interfaces.Parametros
{
    public interface IPersonaRepository
    {
        void Grabar(PersonaTabla persona);
        void Editar(PersonaTabla persona);
        void Eliminar(PersonaTabla persona);
    }
}
