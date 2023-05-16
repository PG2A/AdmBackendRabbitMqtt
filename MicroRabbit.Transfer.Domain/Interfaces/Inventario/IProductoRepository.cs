using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface IProductoRepository
    {
        void GrabarProducto(ProductosTabla productos);
    }
}
