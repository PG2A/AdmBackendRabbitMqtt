using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models.Parametros;

namespace MicroRabbit.Banking.Data.Repository
{
    public class SucursalRepository : ISucursalRepository
    {

        private readonly TablasContext _tablas;

        public SucursalRepository(TablasContext tablas)
        {
            _tablas = tablas;
        }

        public List<SucursalModel> Listar()
        {
            dynamic lista = _tablas.ADM_SUCURSAL.ToList();
            return lista;
        }   

     
    }
}
