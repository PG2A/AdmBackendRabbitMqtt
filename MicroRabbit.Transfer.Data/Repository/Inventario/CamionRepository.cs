using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using MicroRabbit.Transfer.Domain.Models.Parametros;
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

        public void Grabar(CamionTabla camion)
        {
            _tablasContext.Add(camion);
            _tablasContext.SaveChanges();
        }
        public void Editar(CamionTabla camion)
        {
            _tablasContext.Update(camion);
            _tablasContext.SaveChanges();
        }
        public void Eliminar(CamionTabla camion)
        {
            _tablasContext.Remove(camion);
            _tablasContext.SaveChanges();
        }
    }
}
