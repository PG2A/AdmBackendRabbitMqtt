using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface ICamionRepository
    {
        void Grabar(CamionTabla camion);
        void Editar(CamionTabla camion);
        void Eliminar(CamionTabla camion);
    }
}
