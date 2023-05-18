using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface IChoferRepository
    {
        void Grabar(ChoferTabla chofer);
        void Editar(ChoferTabla chofer);
        void Eliminar(ChoferTabla chofer);
    }
}
