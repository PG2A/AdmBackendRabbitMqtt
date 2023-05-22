using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Interfaces.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.CuentasPorPagar;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.CuentasPorPagar
{
    public class ProveedorEventHandler : IEventHandler<ProveedorCreateEvent>
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedorEventHandler(IProveedorRepository ProveedorRepository)
        {
            _proveedorRepository = ProveedorRepository;
        }

        public Task Handle(ProveedorCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new ProveedorTabla
                {
                    Codigo = @event.Codigo,
                    Codigo_Proveedor = @event.Codigo_Proveedor,
                    Sucursal = @event.Sucursal,
                    Nombre = @event.Nombre,
                    Nombre_Comercial = @event.Nombre_Comercial,
                    Direccion = @event.Direccion,
                    Telefono = @event.Telefono,
                    Ruc = @event.Ruc,
                    Correo = @event.Correo,
                    Correofactura = @event.Correofactura,
                    Contacto = @event.Contacto,
                    Bien = @event.Bien,
                    Tipo = @event.Tipo,
                    Categoria = @event.Categoria,
                    Pais = @event.Pais,
                    Ciudad = @event.Ciudad,
                    Tipo_Contribuyente = @event.Tipo_Contribuyente,
                    Dias_Credito = @event.Dias_Credito,
                    Cnt_Gastos = @event.Cnt_Gastos,
                    Observacion = @event.Observacion,
                    Estado = @event.Estado,
                    UsuarioAprobacion = @event.UsuarioAprobacion,
                    FechaAprobacion = @event.FechaAprobacion,
                    UsuarioAutorizacion = @event.UsuarioAutorizacion,
                    FechaAutorizacion = @event.FechaAutorizacion,
                    RutaDocumentos = @event.RutaDocumentos,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                    Relacionado = @event.Relacionado
                };
                _proveedorRepository.GrabarTabla(grabar);
            }
            if (@event.TipoPeticion == "PUT")
            {
                var editar = new ProveedorTabla
                {
                    Codigo = @event.Codigo,
                    Codigo_Proveedor = @event.Codigo_Proveedor,
                    Sucursal = @event.Sucursal,
                    Nombre = @event.Nombre,
                    Nombre_Comercial = @event.Nombre_Comercial,
                    Direccion = @event.Direccion,
                    Telefono = @event.Telefono,
                    Ruc = @event.Ruc,
                    Correo = @event.Correo,
                    Correofactura = @event.Correofactura,
                    Contacto = @event.Contacto,
                    Bien = @event.Bien,
                    Tipo = @event.Tipo,
                    Categoria = @event.Categoria,
                    Pais = @event.Pais,
                    Ciudad = @event.Ciudad,
                    Tipo_Contribuyente = @event.Tipo_Contribuyente,
                    Dias_Credito = @event.Dias_Credito,
                    Cnt_Gastos = @event.Cnt_Gastos,
                    Observacion = @event.Observacion,
                    Estado = @event.Estado,
                    UsuarioAprobacion = @event.UsuarioAprobacion,
                    FechaAprobacion = @event.FechaAprobacion,
                    UsuarioAutorizacion = @event.UsuarioAutorizacion,
                    FechaAutorizacion = @event.FechaAutorizacion,
                    RutaDocumentos = @event.RutaDocumentos,
                    Fecha_Ingreso = @event.Fecha_Ingreso,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                    Relacionado = @event.Relacionado
                };
                _proveedorRepository.EditarTabla(editar);
            }
            return Task.CompletedTask;
        }
    }
}
