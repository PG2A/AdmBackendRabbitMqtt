using MediatR;
using MicroRabbit.Banking.Domain.Commands.CuentasPorPagar.Proveedor;
using MicroRabbit.Banking.Domain.Events.CuentasPorPagar;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.CuentasPorPagar
{
    public class ProveedorCommandHandler : IRequestHandler<CreateProveedorCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public ProveedorCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateProveedorCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new ProveedorCreateEvent(request.Codigo, request.Codigo_Proveedor, request.Sucursal, request.Nombre, request.Nombre_Comercial, request.Direccion, request.Telefono,
                request.Ruc, request.Correo, request.Correofactura, request.Contacto, request.Bien, request.Tipo, request.Categoria, request.Pais, request.Ciudad, request.Tipo_Contribuyente,
                request.Dias_Credito, request.Cnt_Gastos, request.Observacion, request.Estado, request.UsuarioAprobacion, request.FechaAprobacion, request.UsuarioAutorizacion, request.FechaAutorizacion,
                request.RutaDocumentos, request.Fecha_Ingreso, request.Maquina, request.Usuario, request.Relacionado, request.archivo, request.nombreArchivo, request.nombre_Provincia, request.nombreCategoria, 
                request.nombrePais, request.nombreContri, request.nombreDias, request.codigoUsuarioAutorizacion, request.nombreUsuarioAutorizacion, request.TipoPeticion));
            return Task.FromResult(true);
        }
    }
}
