using MicroRabbit.Banking.Application.Interfaces.Contabilidad;
using MicroRabbit.Banking.Application.Models.Contabilidad;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.CuentaContable;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Contabilidad
{
    public class CuentaContableServices : ICuentaContableServices
    {
        private readonly IEventBus _eventBus;

        public CuentaContableServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(CuentaContableModel cuentacontable)
        {
            var createCuentaContableCommand = new CreateCuentaContableCommand(cuentacontable.Anio, cuentacontable.Cuenta, cuentacontable.Nombre, cuentacontable.Naturaleza, cuentacontable.Auxiliar, cuentacontable.Cuentamayor, cuentacontable.Grupo, cuentacontable.Subgrupo,
            cuentacontable.Deb0, cuentacontable.Cre0, cuentacontable.Saldo0, cuentacontable.Deb1, cuentacontable.Cre1, cuentacontable.Saldo1, cuentacontable.Deb2, cuentacontable.Cre2, cuentacontable.Saldo2, cuentacontable.Deb3, cuentacontable.Cre3, cuentacontable.Saldo3, cuentacontable.Deb4,
            cuentacontable.Cre4, cuentacontable.Saldo4, cuentacontable.Deb5, cuentacontable.Cre5, cuentacontable.Saldo5, cuentacontable.Deb6, cuentacontable.Cre6, cuentacontable.Saldo6, cuentacontable.Deb7, cuentacontable.Cre7, cuentacontable.Saldo7, cuentacontable.Deb8,
            cuentacontable.Cre8, cuentacontable.Saldo8, cuentacontable.Deb9, cuentacontable.Cre9, cuentacontable.Saldo9, cuentacontable.Deb10, cuentacontable.Cre10, cuentacontable.Saldo10, cuentacontable.Deb11, cuentacontable.Cre11, cuentacontable.Saldo11, cuentacontable.Deb12,
            cuentacontable.Cre12, cuentacontable.Saldo12, cuentacontable.Deb13, cuentacontable.Cre13, cuentacontable.Saldo13, cuentacontable.CentrodeCosto, cuentacontable.Fecha_Ingreso, cuentacontable.Maquina, cuentacontable.Usuario, cuentacontable.TipoPeticion);
            _eventBus.SendCommand(createCuentaContableCommand);
        }
    }
}
