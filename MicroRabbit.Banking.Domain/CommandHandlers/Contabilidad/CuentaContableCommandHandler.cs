using MediatR;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.CuentaContable;
using MicroRabbit.Banking.Domain.Events.Contabilidad;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Contabilidad
{
    public class CuentaContableCommandHandler : IRequestHandler<CreateCuentaContableCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public CuentaContableCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateCuentaContableCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new CuentaContableCreateEvent(request.Anio, request.Cuenta, request.Nombre, request.Naturaleza, request.Auxiliar, request.Cuentamayor, request.Grupo, request.Subgrupo,
                request.Deb0, request.Cre0, request.Saldo0, request.Deb1, request.Cre1, request.Saldo1, request.Deb2, request.Cre2, request.Saldo2, request.Deb3, request.Cre3, request.Saldo3, request.Deb4,
                request.Cre4, request.Saldo4, request.Deb5, request.Cre5, request.Saldo5, request.Deb6, request.Cre6, request.Saldo6, request.Deb7, request.Cre7, request.Saldo7, request.Deb8,
                request.Cre8, request.Saldo8, request.Deb9, request.Cre9, request.Saldo9, request.Deb10, request.Cre10, request.Saldo10, request.Deb11, request.Cre11, request.Saldo11, request.Deb12,
                request.Cre12, request.Saldo12, request.Deb13, request.Cre13, request.Saldo13, request.CentrodeCosto, request.Fecha_Ingreso, request.Maquina, request.Usuario, request.TipoPeticion));
            return Task.FromResult(true);
        }
    }
}
