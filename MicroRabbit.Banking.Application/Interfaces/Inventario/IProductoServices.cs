using MicroRabbit.Banking.Application.Models.Inventario;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface IProductoServices
    {
        void Enviar(ProductoModel producto);
    }
}
