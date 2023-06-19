using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.AjusteIngreso;
using MicroRabbit.Banking.Domain.Models.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class AjusteIngresoServices : IAjusteIngresoServices
    {
        private readonly IEventBus _eventBus;
        public AjusteIngresoServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(AjusteIngresoModel ajusteIngreso)
        {
            var createAjusteIngresoCommand = new CreateAjusteIngresoCommand(
                ajusteIngreso.Codigo,
                ajusteIngreso.Sucursal,
                ajusteIngreso.Tipo,
                ajusteIngreso.Serie,
                ajusteIngreso.Numero,
                ajusteIngreso.Bodega,
                ajusteIngreso.Cliente,
                ajusteIngreso.Fechaemi,
                ajusteIngreso.Fechaent,
                ajusteIngreso.Bodegaorigen,
                ajusteIngreso.Vendedor,
                ajusteIngreso.Proveedor,
                ajusteIngreso.Peso,
                ajusteIngreso.Volumen,
                ajusteIngreso.Motivo,
                ajusteIngreso.Observacion,
                ajusteIngreso.Comentario,
                ajusteIngreso.Seccontable,
                ajusteIngreso.Estado,
                ajusteIngreso.Estadodoc,
                ajusteIngreso.Enviadosri,
                ajusteIngreso.Numautorizacion,
                ajusteIngreso.Codigorel,
                ajusteIngreso.Fecha_ing,
                ajusteIngreso.Maquina,
                ajusteIngreso.Usuario,
                ajusteIngreso.ClaseAjuste,
                ajusteIngreso.Productos

                );

            _eventBus.SendCommand(createAjusteIngresoCommand);
        }
    }
}
