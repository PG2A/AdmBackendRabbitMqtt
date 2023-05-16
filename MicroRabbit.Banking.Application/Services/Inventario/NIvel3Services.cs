using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel3;
using MicroRabbit.Banking.Domain.Models.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class NIvel3Services : INivel3Services
    {
        private readonly IEventBus _eventBus;
        public NIvel3Services(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(Nivel3Model nivel)
        {
            var createNivel3Command = new CreateNivel3Command(
                nivel.Codigo,
                nivel.Nombre,
                nivel.Estado,
                nivel.Nivel1,
                nivel.Nivel2,
                nivel.Fecha_ing,
                nivel.Maquina,
                nivel.Usuario,
                nivel.Sucursal
                );
            _eventBus.SendCommand(createNivel3Command);
        }
    }
}
