using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using MicroRabbit.Banking.Domain.Commands.Parametros.Precio;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Parametros
{
    public class PrecioServices : IPrecioServices
    {
        private readonly IEventBus _eventBus;

        private ISucursalRepository _sucursalRepository;
        public PrecioServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public PrecioServices(IEventBus eventBus, ISucursalRepository sucursalRepository)
        {
            _eventBus = eventBus;
            _sucursalRepository = sucursalRepository;
        }

        public void Enviar(PrecioModel precio)
        {
            var todas = _sucursalRepository == null ? 0 : _sucursalRepository.Listar().Count();
            var createPrecioCommand = new CreatePrecioCommand(precio.Codigo, precio.Sucursal, precio.Tipo, precio.Precio, precio.Producto, precio.Fecha_ing, precio.Maquina,
            precio.Usuario, precio.PorDes, precio.TipoPeticion, todasSucursales:todas);
            _eventBus.SendCommand(createPrecioCommand);
        }
    }
}
