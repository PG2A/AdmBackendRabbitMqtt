using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Data.Repository.Parametros
{
    public class PersonaRepository : IPersonaRepository
    {
        private TablasContext _tablasContext;

        public PersonaRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void Grabar(PersonaTabla persona)
        {
            _tablasContext.Add(persona);
            _tablasContext.SaveChanges();
        }
    }
}
