using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Domain.Core.Events;
using MicroRabbit.Transfer.Domain.Events.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorCobrar;
using MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar;

namespace MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorCobrar
{
    public class ClienteEventHandller : IEventHandler<ClienteCreateEvent>
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteEventHandller(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Task Handle(ClienteCreateEvent @event)
        {
            var grabar = new ClientesTabla
            {
                Codigo = @event.Codigo,
                Codigo_Cliente = @event.Codigo_Cliente,
                Sucursal = @event.Sucursal,
                Razon_Social = @event.Razon_Social,
                Negocio = @event.Negocio,
                Representate = @event.Representante,
                Fecha_Nacimiento = @event.Fecha_Nacimiento,
                Tipodoc = @event.Tipodoc,
                Ruc = @event.Ruc,
                Direccion = @event.Direccion,
                Referencia = @event.Referencia,
                Celular = @event.Celular,
                Telefono = @event.Telefono,
                Tipo_Contribuyente = @event.Tipo_Contribuyente,
                Estado_Civil = @event.Estado_Civil,
                Correo = @event.Correo,
                Provincia = @event.Provincia,
                Canton = @event.Canton,
                Parroquia = @event.Parroquia,
                Sector = @event.Sector,
                Zona = @event.Zona,
                Categoria = @event.Categoria,
                Tipo_Cliente = @event.Tipo_Cliente,
                Tipo_Negocio  = @event.Tipo_Negocio,
                Medio_Pago = @event.Medio_Pago,
                Ruta_Entrega = @event.Ruta_Entrega,
                Fecha_Ingreso = @event.Fecha_Ingreso,
                Fecha_Ultimacompra = @event.Fecha_Ultimacompra,
                Dvlu = @event.Dvlu,
                Dvma = @event.Dvma,
                Dvmi = @event.Dvmi,
                Dvju = @event.Dvju,
                Dvvi = @event.Dvvi,
                Dvsa = @event.Dvsa,
                Dvdo = @event.Dvdo,
                Frecuencia = @event.Frecuencia,
                Orden = @event.Orden,
                Vendedor = @event.Vendedor,
                Vendedor_Aux = @event.Vendedor_Aux,
                Dias_Credito = @event.Dias_Credito,
                Credito = @event.Credito,
                Cupo = @event.Cupo,
                Extra_Cupo = @event.Extra_Cupo,
                Estado = @event.Estado,
                Clavefe = @event.Clavefe,
                Sexo = @event.Sexo,
                Relacionado = @event.Relacionado,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,
                PrecioAlCosto = @event.PrecioAlCosto,
                PorcentajeIncremento = @event.PorcentajeIncremento
            };
            _clienteRepository.GrabarTabla(grabar);
            return Task.CompletedTask;
        
        }
    }
}
