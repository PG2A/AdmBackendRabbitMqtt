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
    public class MotivosInventarioRepository : IMotivosInventarioRepository
    {
        private TablasContext _tablasContext;

        public MotivosInventarioRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Editar(MotivosInventarioTabla motivosinv)
        {
            _tablasContext.Update(motivosinv);
            _tablasContext.SaveChanges();
        }

        public void Eliminar(MotivosInventarioTabla motivosinv)
        {
            _tablasContext.Remove(motivosinv);
            _tablasContext.SaveChanges();
        }

        public void Grabar(MotivosInventarioTabla motivosinv)
        {
            _tablasContext.Add(motivosinv);
            _tablasContext.SaveChanges();
        }
    }
}
