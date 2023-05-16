using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class Nivel2Repository : INivel2Repository
    {
        private TablasContext _tablasContext;
        public Nivel2Repository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Grabar(Nivel2Tabla nivel)
        {
            _tablasContext.Add(nivel);
            _tablasContext.SaveChanges();
        }
    }
}
