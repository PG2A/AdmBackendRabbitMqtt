using MicroRabbit.Banking.Application.Models.Inventario;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface IMotivosInventarioServices
    {
        void Grabar(MotivosInventarioModel motivosinv);
        void Editar(MotivosInventarioModel motivosinv);
        void Eliminar(MotivosInventarioModel motivosinv);
    }
}
