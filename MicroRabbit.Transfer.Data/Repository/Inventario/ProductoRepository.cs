using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class ProductoRepository : IProductoRepository
    {
        TablasContext _tablasContext;
        public ProductoRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void GrabarProducto(ProductosTabla productos)
        {
            _tablasContext.Add(productos);
            _tablasContext.SaveChanges();
        }
    }
}
