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
            var model = Obtener(clienteTabla.Codigo);
            if(model == null)
            {
                _tablasContext.Add(clienteTabla);
                _tablasContext.SaveChanges();
            }
        }
        public void EditarTabla(ClientesTabla clienteTabla)
        {
            _tablasContext.Update(clienteTabla);
            _tablasContext.SaveChanges();
        }

        public ClientesTabla Obtener(string codigo)
        {
            return _tablasContext.CXC_CLIENTE.Find(codigo);
        }
    }
}
