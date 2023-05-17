using MicroRabbit.Transfer.Domain.Models.Contabilidad;

namespace MicroRabbit.Transfer.Domain.Interfaces.Contabilidad
{
    public interface IBancoCiaRepository
    {
        void GrabarTabla(BancoCiaTabla clienteTabla);
    }
}
