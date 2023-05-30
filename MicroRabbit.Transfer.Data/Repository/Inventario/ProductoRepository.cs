using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class ProductoRepository : IProductoRepository
    {
        TablasContext _tablasContext;

        //IBodegaRepository Bodega;
        //IProductoBodegaRepository ProductoBodega;

        public ProductoRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void GrabarProducto(ProductosTabla productos)
        {
            var model = Obtener(productos.Codigo);
            if (model == null)
            {
                _tablasContext.Add(productos);
                _tablasContext.SaveChanges();
            }
        }
        public void EditarProducto(ProductosTabla productos)
        {
            _tablasContext.Update(productos);
            _tablasContext.SaveChanges();
        }

        public ProductosTabla Obtener(int codigo)
        {
            return _tablasContext.INV_PRODUCTO.Find(codigo);
        }
    }
}
