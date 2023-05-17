using MediatR;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia;
using MicroRabbit.Banking.Domain.Events.Contabilidad;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Contabilidad
{
    public class BancoCiaCommandHandler : IRequestHandler<CreateBancoCiaCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public BancoCiaCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task<bool> Handle(CreateBancoCiaCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new BancoCiaCreateEvent(request.Codigo, request.Inicial_Banco, request.Cuenta, request.Nombre, request.Numero_Cuenta, request.Nombre_cuenta, request.Ultimo_Cheque, request.Tipo_Cuenta, request.Anio,
                request.Contador_Automatico, request.Cuenta_Cheque_Fecha, request.Nombre_cta_cheque, request.Estado, request.Ultima_Conciliacion, request.Fecha_ing, request.FechaRegistro, request.Detalle, 
                request.Maquina, request.Fecha, request.Usuario, request.Sucursal));
            return Task.FromResult(true);

        }
    }
}
