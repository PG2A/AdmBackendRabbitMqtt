using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class Nivel1Services : INivel1Services
    {
        private readonly IEventBus _eventBus;

        public Nivel1Services(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Tranfer(Nivel1Transfer nivel1Transfer)
        {
            var createNivel1Command = new CreateNivel1Command(
                nivel1Transfer.Codigo,
                nivel1Transfer.Nombre,
                nivel1Transfer.Estado,
                nivel1Transfer.Fecha_ing,
                nivel1Transfer.Maquina,
                nivel1Transfer.Usuario,
                nivel1Transfer.Sucursal

                );
            _eventBus.SendCommand(createNivel1Command);
        }
    }
}
