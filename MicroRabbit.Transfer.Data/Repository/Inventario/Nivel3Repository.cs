using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class Nivel3Repository : INivel3Repository
    {

        private readonly TablasContext _tablasContext;

        public Nivel3Repository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Grabar(Nivel3Tabla nivel)
        {
            _tablasContext.Add(nivel);
            _tablasContext.SaveChanges();
        }
    }
}
