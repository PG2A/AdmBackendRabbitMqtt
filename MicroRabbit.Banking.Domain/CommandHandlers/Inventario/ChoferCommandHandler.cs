﻿using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Commands.Inventario.Chofer;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class ChoferCommandHandler
    {
        private readonly IEventBus _eventBus;

        public ChoferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateChoferCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new ChoferCreateEvent(request.Codigo, request.Nombre, request.Cedula, request.Direccion, request.Celular,
                request.Observacion, request.Estado, request.Fecha_Ingreso, request.Detalle, request.Maquina, request.Usuario, request.Sucursal));
            return Task.FromResult(true);
        }
    }
}
