using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Models.CuentasPorPagar
{
    public class ProveedorFarmaciaModel
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
    }
}
