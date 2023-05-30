using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class ProductoBodegaRepository : IProductoBodegaRepository
    {
        TablasContext _tablasContext;
        public ProductoBodegaRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }
        public void Grabar(InvProductoBodegaTabla productobodega)
        {
            _tablasContext.Add(productobodega);
            _tablasContext.SaveChanges();
        }
    }
}
