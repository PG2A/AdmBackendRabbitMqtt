using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Domain.Interfaces.Parametros
{
    public interface IPrecioRepository
    {
        void GrabarTabla(PrecioTabla precioTabla);
        void EditarTabla(PrecioTabla precioTabla);
    }
}
