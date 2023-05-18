using MicroRabbit.Banking.Application.Interfaces.Contabilidad;
using MicroRabbit.Banking.Application.Models.Contabilidad;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Contabilidad
{
    public class BancoCiaServices : IBancoCiaServices
    {
        private readonly IEventBus _eventBus;

        public BancoCiaServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Editar(BancoCiaModel bancocia)
        {
            var createBancoCiaCommand = new CreateBancoCiaCommand(bancocia.Codigo, bancocia.Inicial_Banco, bancocia.Cuenta, bancocia.Nombre, bancocia.Numero_Cuenta, bancocia.Nombre_cuenta, bancocia.Ultimo_Cheque, bancocia.Tipo_Cuenta, bancocia.Anio,
            bancocia.Contador_Automatico, bancocia.Cuenta_Cheque_Fecha, bancocia.Nombre_cta_cheque, bancocia.Estado, bancocia.Ultima_Conciliacion, bancocia.Fecha_ing, bancocia.FechaRegistro, bancocia.Detalle,
            bancocia.Maquina, bancocia.Fecha, bancocia.Usuario, bancocia.Sucursal, bancocia.TipoPeticion);
            _eventBus.SendCommand(createBancoCiaCommand);
        }

        public void Eliminar(BancoCiaModel bancocia)
        {
            var createBancoCiaCommand = new CreateBancoCiaCommand(bancocia.Codigo, bancocia.Inicial_Banco, bancocia.Cuenta, bancocia.Nombre, bancocia.Numero_Cuenta, bancocia.Nombre_cuenta, bancocia.Ultimo_Cheque, bancocia.Tipo_Cuenta, bancocia.Anio,
            bancocia.Contador_Automatico, bancocia.Cuenta_Cheque_Fecha, bancocia.Nombre_cta_cheque, bancocia.Estado, bancocia.Ultima_Conciliacion, bancocia.Fecha_ing, bancocia.FechaRegistro, bancocia.Detalle,
            bancocia.Maquina, bancocia.Fecha, bancocia.Usuario, bancocia.Sucursal, bancocia.TipoPeticion);
            _eventBus.SendCommand(createBancoCiaCommand);
        }

        public void Enviar(BancoCiaModel bancocia)
        {
            var createBancoCiaCommand = new CreateBancoCiaCommand(bancocia.Codigo, bancocia.Inicial_Banco, bancocia.Cuenta, bancocia.Nombre, bancocia.Numero_Cuenta, bancocia.Nombre_cuenta, bancocia.Ultimo_Cheque, bancocia.Tipo_Cuenta, bancocia.Anio,
            bancocia.Contador_Automatico, bancocia.Cuenta_Cheque_Fecha, bancocia.Nombre_cta_cheque, bancocia.Estado, bancocia.Ultima_Conciliacion, bancocia.Fecha_ing, bancocia.FechaRegistro, bancocia.Detalle,
            bancocia.Maquina, bancocia.Fecha, bancocia.Usuario, bancocia.Sucursal, bancocia.TipoPeticion);
            _eventBus.SendCommand(createBancoCiaCommand);
        }
    }
}
