using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Contabilidad;
using MicroRabbit.Transfer.Domain.Interfaces.Contabilidad;
using MicroRabbit.Transfer.Domain.Models.Contabilidad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Contabilidad
{
    public class CuentaContableEventHandler : IEventHandler<CuentaContableCreateEvent>
    {
        private readonly ICuentaContableRepository _cuentaContableRepository;

        public CuentaContableEventHandler(ICuentaContableRepository cuentaContableRepository)
        {
            _cuentaContableRepository = cuentaContableRepository;
        }

        public Task Handle(CuentaContableCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new CuentaContableTabla
                {
                    Anio = @event.Anio,
                    Cuenta = @event.Cuenta,
                    Nombre = @event.Nombre,
                    Naturaleza = @event.Naturaleza,
                    Auxiliar = @event.Auxiliar,
                    Cuentamayor = @event.Cuentamayor,
                    Grupo = @event.Grupo,
                    Subgrupo = @event.Subgrupo,
                    Deb0 = @event.Deb0,
                    Cre0 = @event.Cre0,
                    Saldo0 = @event.Saldo0,
                    Deb1 = @event.Deb1,
                    Cre1 = @event.Cre1,
                    Saldo1 = @event.Saldo1,
                    Deb2 = @event.Deb2,
                    Cre2 = @event.Cre2,
                    Saldo2 = @event.Saldo2,
                    Deb3 = @event.Deb3,
                    Cre3 = @event.Cre3,
                    Saldo3 = @event.Saldo3,
                    Deb4 = @event.Deb4,
                    Cre4 = @event.Cre4,
                    Saldo4 = @event.Saldo4,
                    Deb5 = @event.Deb5,
                    Cre5 = @event.Cre5,
                    Saldo5 = @event.Saldo5,
                    Deb6 = @event.Deb6,
                    Cre6 = @event.Cre6,
                    Saldo6 = @event.Saldo6,
                    Deb7 = @event.Deb7,
                    Cre7 = @event.Cre7,
                    Saldo7 = @event.Saldo7,
                    Deb8 = @event.Deb8,
                    Cre8 = @event.Cre8,
                    Saldo8 = @event.Saldo8,
                    Deb9 = @event.Deb9,
                    Cre9 = @event.Cre9,
                    Saldo9 = @event.Saldo9,
                    Deb10 = @event.Deb10,
                    Cre10 = @event.Cre10,
                    Saldo10 = @event.Saldo10,
                    Deb11 = @event.Deb11,
                    Cre11 = @event.Cre11,
                    Saldo11 = @event.Saldo11,
                    Deb12 = @event.Deb12,
                    Cre12 = @event.Cre12,
                    Saldo12 = @event.Saldo12,
                    Deb13 = @event.Deb13,
                    Cre13 = @event.Cre13,
                    Saldo13 = @event.Saldo13,
                    CentrodeCosto = @event.CentrodeCosto,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                };
                _cuentaContableRepository.GrabarTabla(grabar);
            }
            if(@event.TipoPeticion == "PUT")
            {
                var editar = new CuentaContableTabla
                {
                    Anio = @event.Anio,
                    Cuenta = @event.Cuenta,
                    Nombre = @event.Nombre,
                    Naturaleza = @event.Naturaleza,
                    Auxiliar = @event.Auxiliar,
                    Cuentamayor = @event.Cuentamayor,
                    Grupo = @event.Grupo,
                    Subgrupo = @event.Subgrupo,
                    Deb0 = @event.Deb0,
                    Cre0 = @event.Cre0,
                    Saldo0 = @event.Saldo0,
                    Deb1 = @event.Deb1,
                    Cre1 = @event.Cre1,
                    Saldo1 = @event.Saldo1,
                    Deb2 = @event.Deb2,
                    Cre2 = @event.Cre2,
                    Saldo2 = @event.Saldo2,
                    Deb3 = @event.Deb3,
                    Cre3 = @event.Cre3,
                    Saldo3 = @event.Saldo3,
                    Deb4 = @event.Deb4,
                    Cre4 = @event.Cre4,
                    Saldo4 = @event.Saldo4,
                    Deb5 = @event.Deb5,
                    Cre5 = @event.Cre5,
                    Saldo5 = @event.Saldo5,
                    Deb6 = @event.Deb6,
                    Cre6 = @event.Cre6,
                    Saldo6 = @event.Saldo6,
                    Deb7 = @event.Deb7,
                    Cre7 = @event.Cre7,
                    Saldo7 = @event.Saldo7,
                    Deb8 = @event.Deb8,
                    Cre8 = @event.Cre8,
                    Saldo8 = @event.Saldo8,
                    Deb9 = @event.Deb9,
                    Cre9 = @event.Cre9,
                    Saldo9 = @event.Saldo9,
                    Deb10 = @event.Deb10,
                    Cre10 = @event.Cre10,
                    Saldo10 = @event.Saldo10,
                    Deb11 = @event.Deb11,
                    Cre11 = @event.Cre11,
                    Saldo11 = @event.Saldo11,
                    Deb12 = @event.Deb12,
                    Cre12 = @event.Cre12,
                    Saldo12 = @event.Saldo12,
                    Deb13 = @event.Deb13,
                    Cre13 = @event.Cre13,
                    Saldo13 = @event.Saldo13,
                    CentrodeCosto = @event.CentrodeCosto,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                };
                _cuentaContableRepository.EditarTabla(editar);
            }
            if (@event.TipoPeticion == "DELETE")
            {
                var eliminar = new CuentaContableTabla
                {
                    Anio = @event.Anio,
                    Cuenta = @event.Cuenta,
                    Nombre = @event.Nombre,
                    Naturaleza = @event.Naturaleza,
                    Auxiliar = @event.Auxiliar,
                    Cuentamayor = @event.Cuentamayor,
                    Grupo = @event.Grupo,
                    Subgrupo = @event.Subgrupo,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                };
                _cuentaContableRepository.EliminarTabla(eliminar);
            }
            return Task.CompletedTask;
        }
    }
}
