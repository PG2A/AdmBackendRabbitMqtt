using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class CamionEventHandler : IEventHandler<CamionCreateEvent>
    {
        private readonly ICamionRepository _camionRepository;

        public CamionEventHandler(ICamionRepository camionRepository)
        {
            _camionRepository = camionRepository;
        }

        public Task Handle(CamionCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new CamionTabla
                {
                    Codigo = @event.Codigo,
                    Nombre = @event.Nombre,
                    Placa = @event.Placa,
                    Volumen = @event.Volumen,
                    Anio = @event.Anio,
                    Peso = @event.Peso,
                    Chofer = @event.Chofer,
                    Estado = @event.Estado,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                    Sucursal = @event.Sucursal,
                };
                _camionRepository.Grabar(grabar);
            }
            else if (@event.TipoPeticion == "PUT")
            {
                var editar = new CamionTabla
                {
                    Codigo = @event.Codigo,
                    Nombre = @event.Nombre,
                    Placa = @event.Placa,
                    Volumen = @event.Volumen,
                    Anio = @event.Anio,
                    Peso = @event.Peso,
                    Chofer = @event.Chofer,
                    Estado = @event.Estado,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                    Sucursal = @event.Sucursal,
                };
                _camionRepository.Grabar(editar);
            }
            else if (@event.TipoPeticion == "DELETE")
            {
                var eliminar = new CamionTabla
                {
                    Codigo = @event.Codigo,
                    //Nombre = @event.Nombre,
                    //Placa = @event.Placa,
                    //Volumen = @event.Volumen,
                    //Anio = @event.Anio,
                    //Peso = @event.Peso,
                    //Chofer = @event.Chofer,
                    //Estado = @event.Estado,
                    //Fecha_Ingreso = @event.Fecha_Ingreso,
                    //Maquina = @event.Maquina,
                    //Usuario = @event.Usuario,
                    //Sucursal = @event.Sucursal,
                };
                _camionRepository.Grabar(eliminar);
            }
            return Task.CompletedTask;
        }
    }
}
