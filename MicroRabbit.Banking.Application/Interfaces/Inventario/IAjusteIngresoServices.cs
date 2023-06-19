using MicroRabbit.Banking.Domain.Models.Inventario;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface IAjusteIngresoServices
    {
        void Enviar(AjusteIngresoModel ajusteIngreso);
    }
}
