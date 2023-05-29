using MediatR;
using MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente;
using MicroRabbit.Banking.Domain.Events.CuentasPorCobrar;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;


namespace MicroRabbit.Banking.Domain.CommandHandlers.CuentasPorCobrar
{
    public class ClienteCommanHandler : IRequestHandler<CreateClienteCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public ClienteCommanHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            for (int i = 0; i < request.TodasSucursales; i++)
            {
                _eventBus.Publish(new ClienteCreateEvent(request.Codigo, request.Codigo_Cliente, request.Sucursal, request.Razon_Social, request.Negocio, request.Representante
            , request.Fecha_Nacimiento, request.Tipodoc, request.Ruc, request.Direccion, request.Referencia, request.Celular, request.Telefono, request.Tipo_Contribuyente,
            request.Correo, request.Provincia, request.Canton, request.Parroquia, request.Sector, request.Zona, request.Categoria, request.Tipo_Cliente, request.Tipo_Negocio,
            request.Medio_Pago, request.Ruta_Entrega, request.Fecha_Ingreso, request.Fecha_Ultimacompra, request.Dvlu, request.Dvma, request.Dvmi, request.Dvju, request.Dvvi,
            request.Dvsa, request.Dvdo, request.Frecuencia, request.Orden, request.Vendedor, request.Vendedor_Aux, request.Dias_Credito, request.Credito, request.Cupo, request.Extra_Cupo, request.Estado, request.Clavefe,
            request.Sexo, request.Estado_Civil, request.Maquina, request.Usuario, request.Relacionado, request.PrecioAlCosto, request.PorcentajeIncremento, request.TipoPeticion
            ));
            }
            return Task.FromResult(true);
        }
    }
}
