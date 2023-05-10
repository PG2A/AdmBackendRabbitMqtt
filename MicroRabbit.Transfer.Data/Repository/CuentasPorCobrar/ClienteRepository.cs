using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar;


namespace MicroRabbit.Transfer.Data.Repository.CuentasPorCobrar
{
    public class ClienteRepository : IClienteRepository
    {

       private TablasContext _tablasContext;

        public ClienteRepository(TablasContext tablasContext)
        {
            _tablasContext = tablasContext;
        }

        public void GrabarTabla(ClientesTabla clienteTabla)
        {
            _tablasContext.Add(clienteTabla);
            _tablasContext.SaveChanges();
        }
    }
}
