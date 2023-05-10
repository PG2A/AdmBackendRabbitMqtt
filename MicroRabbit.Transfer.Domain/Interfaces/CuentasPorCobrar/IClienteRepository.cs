using MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar;


namespace MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar
{
    public interface IClienteRepository
    {
        void GrabarTabla(ClientesTabla clienteTabla);
    }
}
