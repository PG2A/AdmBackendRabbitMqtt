using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Contabilidad;
using MicroRabbit.Transfer.Domain.Interfaces.Contabilidad;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Models.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Contabilidad
{
    public class BancoCiaEventHandler : IEventHandler<BancoCiaCreateEvent>
    {
        private readonly IBancoCiaRepository _bancoCiaRepository;

        public BancoCiaEventHandler(IBancoCiaRepository bancoCiaRepository)
        {
            _bancoCiaRepository = bancoCiaRepository;
        }

        public Task Handle(BancoCiaCreateEvent @event)
        {
            var grabar = new BancoCiaTabla
            {
                Codigo = @event.Codigo,
                Inicial_Banco = @event.Inicial_Banco,
                Cuenta = @event.Cuenta,
                Nombre = @event.Nombre,
                Numero_Cuenta = @event.Numero_Cuenta,
                Ultimo_Cheque = @event.Ultimo_Cheque,
                Tipo_Cuenta = @event.Tipo_Cuenta,
                Anio = @event.Anio,
                Contador_Automatico = @event.Contador_Automatico,
                Cuenta_Cheque_Fecha = @event.Cuenta_Cheque_Fecha,
                Estado = @event.Estado,
                Ultima_Conciliacion = @event.Ultima_Conciliacion,
                Fecha_ing = @event.Fecha_ing,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,
            };
            _bancoCiaRepository.GrabarTabla(grabar);
            return Task.CompletedTask;
        }
    }
}
