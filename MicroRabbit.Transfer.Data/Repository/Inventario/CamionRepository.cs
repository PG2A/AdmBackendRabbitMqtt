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
    public class CamionRepository : ICamionRepository 
    {
        private TablasContext _tablasContext;
        public CamionRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Grabar(CamionTabla nivel)
        {
            _tablasContext.Add(nivel);
            _tablasContext.SaveChanges();
        }
    }
}
