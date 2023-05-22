using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.MotivosInventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class MotivosInventarioServices : IMotivosInventarioServices
    {
        private readonly IEventBus _eventBus;

        public MotivosInventarioServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Editar(MotivosInventarioModel motivosinv)
        {
            var createMotivosInvCommand = new CreateMotivosInventarioCommand(motivosinv.Codigo, motivosinv.Nombre, motivosinv.Cuenta, motivosinv.Estadistica, motivosinv.Sri, motivosinv.TipoDocInventario, motivosinv.Estado, motivosinv.Fecha_ing, motivosinv.Maquina, motivosinv.Usuario, motivosinv.TipoPeticion);
            _eventBus.SendCommand(createMotivosInvCommand);
        }

        public void Eliminar(MotivosInventarioModel motivosinv)
        {
            var createMotivosInvCommand = new CreateMotivosInventarioCommand(motivosinv.Codigo, motivosinv.Nombre, motivosinv.Cuenta, motivosinv.Estadistica, motivosinv.Sri, motivosinv.TipoDocInventario, motivosinv.Estado, motivosinv.Fecha_ing, motivosinv.Maquina, motivosinv.Usuario, motivosinv.TipoPeticion);
            _eventBus.SendCommand(createMotivosInvCommand);
        }

        public void Grabar(MotivosInventarioModel motivosinv)
        {
            var createMotivosInvCommand = new CreateMotivosInventarioCommand(motivosinv.Codigo, motivosinv.Nombre, motivosinv.Cuenta, motivosinv.Estadistica, motivosinv.Sri, motivosinv.TipoDocInventario, motivosinv.Estado, motivosinv.Fecha_ing, motivosinv.Maquina, motivosinv.Usuario, motivosinv.TipoPeticion);
            _eventBus.SendCommand(createMotivosInvCommand);
        }
    }
}
