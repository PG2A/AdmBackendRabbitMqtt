using MicroRabbit.Transfer.Domain.Models.Contabilidad;

namespace MicroRabbit.Transfer.Domain.Interfaces.Contabilidad
{
    public interface ICuentaContableRepository
    {
        void GrabarTabla(CuentaContableTabla cuentacontable);
        void EditarTabla(CuentaContableTabla cuentacontable);
        void EliminarTabla(CuentaContableTabla cuentacontable);
    }
}
