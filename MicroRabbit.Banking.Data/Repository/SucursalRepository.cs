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

        //public void Listar()
        //{
        //    var lista =_tablas.ADM_SUCURSAL.ToList();
        //    Console.WriteLine(lista);
        //}

        //List<SucursalModel> ISucursalRepository.Listar()
        //{
        //    var lista = _tablas.ADM_SUCURSAL.ToList();
        //    return lista;
        //}
    }
}
