using MicroRabbit.Banking.Application.Models.Inventario;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface ICamionServices
    {
        void Transfer(CamionModel camion);
        void Editar(CamionModel camion);
        void Eliminar(CamionModel camion);
    }
}
