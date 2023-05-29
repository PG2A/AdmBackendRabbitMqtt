using MicroRabbit.Banking.Application.Models.Parametros;

namespace MicroRabbit.Banking.Application.Interfaces.Parametros
{
    public interface IPrecioServices
    {
        void Enviar(PrecioModel precio);
    }
}
