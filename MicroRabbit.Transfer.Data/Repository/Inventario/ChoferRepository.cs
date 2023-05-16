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
    public class ChoferRepository : IChoferRepository
    {
        private TablasContext _tablasContext;
        public ChoferRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Grabar(ChoferTabla chofer)
        {
            _tablasContext.Add(chofer);
            _tablasContext.SaveChanges();
        }
    }
}
