using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.CuentasPorPagar.Proveedor
{
    public class CreateProveedorCommand : ProveedorCommand
    {
        public CreateProveedorCommand(int? codigo, string codigo_Proveedor, int sucursal, string nombre, string nombre_Comercial, string direccion, string telefono, string ruc, string correo, string correofactura, string contacto, char bien, string tipo, string categoria, string pais, string ciudad, int tipo_Contribuyente, int dias_Credito, int cnt_Gastos, string observacion, bool estado, int usuarioAprobacion, DateTime fechaAprobacion, int? usuarioAutorizacion, DateTime? fechaAutorizacion, string? rutaDocumentos, DateTime? fecha_Ingreso, string maquina, int usuario, int relacionado, string? archivo, string? nombreArchivo, string? nombre_Provincia, string? nombreCategoria, string? nombrePais, string? nombreContri, string? nombreDias, string? codigoUsuarioAutorizacion, string? nombreUsuarioAutorizacion, string tipopeticion)
        {
            Codigo = codigo;
            Codigo_Proveedor = codigo_Proveedor;
            Sucursal = sucursal;
            Nombre = nombre;
            Nombre_Comercial = nombre_Comercial;
            Direccion = direccion;
            Telefono = telefono;
            Ruc = ruc;
            Correo = correo;
            Correofactura = correofactura;
            Contacto = contacto;
            Bien = bien;
            Tipo = tipo;
            Categoria = categoria;
            Pais = pais;
            Ciudad = ciudad;
            Tipo_Contribuyente = tipo_Contribuyente;
            Dias_Credito = dias_Credito;
            Cnt_Gastos = cnt_Gastos;
            Observacion = observacion;
            Estado = estado;
            UsuarioAprobacion = usuarioAprobacion;
            FechaAprobacion = fechaAprobacion;
            UsuarioAutorizacion = usuarioAutorizacion;
            FechaAutorizacion = fechaAutorizacion;
            RutaDocumentos = rutaDocumentos;
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
            Relacionado = relacionado;
            this.archivo = archivo;
            this.nombreArchivo = nombreArchivo;
            this.nombre_Provincia = nombre_Provincia;
            this.nombreCategoria = nombreCategoria;
            this.nombrePais = nombrePais;
            this.nombreContri = nombreContri;
            this.nombreDias = nombreDias;
            this.codigoUsuarioAutorizacion = codigoUsuarioAutorizacion;
            this.nombreUsuarioAutorizacion = nombreUsuarioAutorizacion;
            TipoPeticion = tipopeticion;
        }
    }
}
