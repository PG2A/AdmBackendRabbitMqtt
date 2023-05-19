using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.Camion;
using MicroRabbit.Banking.Domain.Commands.Inventario.Chofer;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class ChoferServices : IChoferServices
    {
        private readonly IEventBus _eventBus;

        public ChoferServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Editar(ChoferModel chofer)
        {
            var createChoferCommand = new CreateChoferCommand(chofer.Codigo, chofer.Nombre, chofer.Cedula, chofer.Direccion, chofer.Celular,
                chofer.Observacion, chofer.Estado, chofer.Fecha_Ingreso, chofer.Detalle, chofer.Maquina, chofer.Usuario, chofer.Sucursal);
            _eventBus.SendCommand(createChoferCommand);
        }

        public void Eliminar(ChoferModel chofer)
        {
            var createChoferCommand = new CreateChoferCommand(chofer.Codigo, chofer.Nombre, chofer.Cedula, chofer.Direccion, chofer.Celular,
                chofer.Observacion, chofer.Estado, chofer.Fecha_Ingreso, chofer.Detalle, chofer.Maquina, chofer.Usuario, chofer.Sucursal);
            _eventBus.SendCommand(createChoferCommand);
        }

        public void Transfer(ChoferModel chofer)
        {
            var createChoferCommand = new CreateChoferCommand(chofer.Codigo, chofer.Nombre, chofer.Cedula, chofer.Direccion, chofer.Celular,
                chofer.Observacion, chofer.Estado, chofer.Fecha_Ingreso, chofer.Detalle, chofer.Maquina, chofer.Usuario, chofer.Sucursal);
            _eventBus.SendCommand(createChoferCommand);
        }
    }
}
