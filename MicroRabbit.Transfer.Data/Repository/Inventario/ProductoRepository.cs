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

        //public ProductoRepository(TablasContext tablasContext, IBodegaRepository bodega, IProductoBodegaRepository productobodega)
        //{
        //    _tablasContext = tablasContext;
        //    Bodega = bodega;
        //    ProductoBodega = productobodega;
        //}

        public void GrabarProducto(ProductosTabla productos)
        {
            _tablasContext.Add(productos);
            //var lista = Bodega.ObtenerRegistros();
            //foreach (var item in lista)
            //{
            //    var codigoBodega = lista.Where(x => x.Codigo_Bodega == item.Codigo_Bodega).ToList();
            //    var model = new InvProductoBodegaTabla
            //    {
            //        Bodega = codigoBodega.FirstOrDefault().Codigo,
            //        Producto = item.Codigo,
            //        Stock = 0,
            //    };
            //    ProductoBodega.Grabar(model);
            //}
            _tablasContext.SaveChanges();
        }
        public void EditarProducto(ProductosTabla productos)
        {
            _tablasContext.Update(productos);
            _tablasContext.SaveChanges();
        }
    }
}
