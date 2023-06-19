

using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.AjusteIngreso;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class AjusteIngresoCommandHandler : IRequestHandler<CreateAjusteIngresoCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public AjusteIngresoCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateAjusteIngresoCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new AjusteIngresoCreateEvent(
                request.Codigo,
                request.Sucursal,
                request.Tipo,
                request.Serie,
                request.Numero,
                request.Bodega,
                request.Cliente,
                request.Fechaemi,
                request.Fechaent,
                request.Bodegaorigen,
                request.Vendedor,
                request.Proveedor,
                request.Peso,
                request.Volumen,
                request.Motivo,
                request.Observacion,
                request.Comentario,
                request.Seccontable,
                request.Estado,
                request.Estadodoc,
                request.Enviadosri,
                request.Numautorizacion,
                request.Codigorel,
                request.Fecha_ing,
                request.Maquina,
                request.Usuario,
                request.ClaseAjuste,
                request.Productos
                
                ));
            return Task.FromResult(true);   
        }
    }
}
