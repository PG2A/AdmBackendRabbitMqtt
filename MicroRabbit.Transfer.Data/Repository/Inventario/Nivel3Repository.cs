using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models;



namespace MicroRabbit.Transfer.Data.Repository.Inventario
{
    public class Nivel3Repository : INivelRepository
    {

        private readonly TablasContext tablasContext;

        public Nivel3Repository(TablasContext tablasContext)
        {
            this.tablasContext = tablasContext;
        }

        public void AddNivel1(Nivel1Tabla nivel1)
        {
            throw new NotImplementedException();
        }
    }
}
