using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel2;
using MicroRabbit.Banking.Domain.Models.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class Nivel2Services : INivel2Services
    {
        private readonly IEventBus _bus;

        public Nivel2Services(IEventBus bus)
        {
            _bus = bus;
        }

        public void Enviar(Nivel2Model nivel)
        {
            var createNivel2Command = new CreateNivel2Command(
                nivel.Codigo,
                nivel.Nombre,
                nivel.Estado,
                nivel.Nivel1,
                nivel.Fecha_ing,
                nivel.Maquina,
                nivel.Usuario,
                nivel.Sucursal
             );
            _bus.SendCommand(createNivel2Command);
        }
    }
}
