using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using MicroRabbit.Banking.Domain.Commands.Parametros.Precio;
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

        public PrecioServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(PrecioModel precio)
        {
            var createPrecioCommand = new CreatePrecioCommand(precio.Codigo, precio.Sucursal, precio.Tipo, precio.Precio, precio.Producto, precio.Fecha_ing, precio.Maquina,
            precio.Usuario, precio.PorDes, precio.TipoPeticion);
            _eventBus.SendCommand(createPrecioCommand);
        }
    }
}
