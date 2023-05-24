using MicroRabbit.Banking.Application.Models.Contabilidad;

namespace MicroRabbit.Banking.Application.Interfaces.Contabilidad
{
    public interface ICuentaContableServices
    {
        void Enviar(CuentaContableModel cuentacontable);
    }
}
