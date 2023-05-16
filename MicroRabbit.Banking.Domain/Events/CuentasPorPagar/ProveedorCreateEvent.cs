using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.CuentasPorPagar
{
    public class ProveedorCreateEvent : Event
    {
        public int? Codigo { get; set; }
        public string Codigo_Proveedor { get; set; }
        public int Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Comercial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ruc { get; set; }
        public string Correo { get; set; }
        public string Correofactura { get; set; }
        public string Contacto { get; set; }
        public char Bien { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public int Tipo_Contribuyente { get; set; }
        public int Dias_Credito { get; set; }
        public int Cnt_Gastos { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public int UsuarioAprobacion { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public int? UsuarioAutorizacion { get; set; }
        public DateTime? FechaAutorizacion { get; set; }
        public string? RutaDocumentos { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public int Relacionado { get; set; }
        public string? archivo { get; set; }
        public string? nombreArchivo { get; set; }
        public string? nombre_Provincia { get; set; }
        public string? nombreCategoria { get; set; }
        public string? nombrePais { get; set; }
        public string? nombreContri { get; set; }
        public string? nombreDias { get; set; }
        public string? codigoUsuarioAutorizacion { get; set; }
        public string? nombreUsuarioAutorizacion { get; set; }

        public ProveedorCreateEvent(int? codigo, string codigo_Proveedor, int sucursal, string nombre, string nombre_Comercial, string direccion, string telefono, string ruc, string correo, string correofactura, string contacto, char bien, string tipo, string categoria, string pais, string ciudad, int tipo_Contribuyente, int dias_Credito, int cnt_Gastos, string observacion, bool estado, int usuarioAprobacion, DateTime fechaAprobacion, int? usuarioAutorizacion, DateTime? fechaAutorizacion, string? rutaDocumentos, DateTime? fecha_Ingreso, string maquina, int usuario, int relacionado, string? archivo, string? nombreArchivo, string? nombre_Provincia, string? nombreCategoria, string? nombrePais, string? nombreContri, string? nombreDias, string? codigoUsuarioAutorizacion, string? nombreUsuarioAutorizacion)
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
        }
    }
}
