using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface IMotivosInventarioRepository
    {
        void Grabar(MotivosInventarioTabla motivosinv);
        void Editar(MotivosInventarioTabla motivosinv);
        void Eliminar(MotivosInventarioTabla motivosinv);
    }
}
