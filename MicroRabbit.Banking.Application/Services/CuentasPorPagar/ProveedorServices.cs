using MediatR;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Models.CuentasPorPagar;
using MicroRabbit.Banking.Domain.Commands.CuentasPorPagar.Proveedor;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.CuentasPorPagar
{
    public class ProveedorServices : IProveedorServices
    {
        private readonly IEventBus _eventBus;

        public ProveedorServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(ProveedorFarmaciaModel proveedor)
        {
            var createProveedorCommand = new CreateProveedorCommand(proveedor.Codigo, proveedor.Codigo_Proveedor, proveedor.Sucursal, proveedor.Nombre, proveedor.Nombre_Comercial, proveedor.Direccion, proveedor.Telefono,
            proveedor.Ruc, proveedor.Correo, proveedor.Correofactura, proveedor.Contacto, proveedor.Bien, proveedor.Tipo, proveedor.Categoria, proveedor.Pais, proveedor.Ciudad, proveedor.Tipo_Contribuyente,
            proveedor.Dias_Credito, proveedor.Cnt_Gastos, proveedor.Observacion, proveedor.Estado, proveedor.UsuarioAprobacion, proveedor.FechaAprobacion, proveedor.UsuarioAutorizacion, proveedor.FechaAutorizacion,
            proveedor.RutaDocumentos, proveedor.Fecha_Ingreso, proveedor.Maquina, proveedor.Usuario, proveedor.Relacionado, proveedor.archivo, proveedor.nombreArchivo, proveedor.nombre_Provincia, proveedor.nombreCategoria,
                proveedor.nombrePais, proveedor.nombreContri, proveedor.nombreDias, proveedor.codigoUsuarioAutorizacion, proveedor.nombreUsuarioAutorizacion, proveedor.TipoPeticion);
            _eventBus.SendCommand(createProveedorCommand);
        }
        public void Editar(ProveedorFarmaciaModel proveedor)
        {
            var createProveedorCommand = new CreateProveedorCommand(proveedor.Codigo, proveedor.Codigo_Proveedor, proveedor.Sucursal, proveedor.Nombre, proveedor.Nombre_Comercial, proveedor.Direccion, proveedor.Telefono,
            proveedor.Ruc, proveedor.Correo, proveedor.Correofactura, proveedor.Contacto, proveedor.Bien, proveedor.Tipo, proveedor.Categoria, proveedor.Pais, proveedor.Ciudad, proveedor.Tipo_Contribuyente,
            proveedor.Dias_Credito, proveedor.Cnt_Gastos, proveedor.Observacion, proveedor.Estado, proveedor.UsuarioAprobacion, proveedor.FechaAprobacion, proveedor.UsuarioAutorizacion, proveedor.FechaAutorizacion,
            proveedor.RutaDocumentos, proveedor.Fecha_Ingreso, proveedor.Maquina, proveedor.Usuario, proveedor.Relacionado, proveedor.archivo, proveedor.nombreArchivo, proveedor.nombre_Provincia, proveedor.nombreCategoria,
                proveedor.nombrePais, proveedor.nombreContri, proveedor.nombreDias, proveedor.codigoUsuarioAutorizacion, proveedor.nombreUsuarioAutorizacion, proveedor.TipoPeticion);
            _eventBus.SendCommand(createProveedorCommand);
        }
        public void Eliminar(ProveedorFarmaciaModel proveedor)
        {
            var createProveedorCommand = new CreateProveedorCommand(proveedor.Codigo, proveedor.Codigo_Proveedor, proveedor.Sucursal, proveedor.Nombre, proveedor.Nombre_Comercial, proveedor.Direccion, proveedor.Telefono,
            proveedor.Ruc, proveedor.Correo, proveedor.Correofactura, proveedor.Contacto, proveedor.Bien, proveedor.Tipo, proveedor.Categoria, proveedor.Pais, proveedor.Ciudad, proveedor.Tipo_Contribuyente,
            proveedor.Dias_Credito, proveedor.Cnt_Gastos, proveedor.Observacion, proveedor.Estado, proveedor.UsuarioAprobacion, proveedor.FechaAprobacion, proveedor.UsuarioAutorizacion, proveedor.FechaAutorizacion,
            proveedor.RutaDocumentos, proveedor.Fecha_Ingreso, proveedor.Maquina, proveedor.Usuario, proveedor.Relacionado, proveedor.archivo, proveedor.nombreArchivo, proveedor.nombre_Provincia, proveedor.nombreCategoria,
                proveedor.nombrePais, proveedor.nombreContri, proveedor.nombreDias, proveedor.codigoUsuarioAutorizacion, proveedor.nombreUsuarioAutorizacion, proveedor.TipoPeticion);
            _eventBus.SendCommand(createProveedorCommand);
        }
    }
}
