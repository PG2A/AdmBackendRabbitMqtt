using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Parametros
{
    public class SucursalServices : ISucursalServices
    {
        private ISucursalRepository _sucursalRepository;

        public SucursalServices(ISucursalRepository sucursalRepository)
        {
            _sucursalRepository = sucursalRepository;
        }

        public List<SucursalModel> Obtener()
        {
            dynamic lista = _sucursalRepository.Listar();
            return lista;
        }
    }
}
