using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Transfer.Domain.Models.CuentasPorCobrar
{
    public class ClientesTabla
    {
        [Key]
        public string Codigo { get; set; }
        public string Codigo_Cliente { get; set; }
        public int Sucursal { get; set; }
        public string Razon_Social { get; set; }
        public string Negocio { get; set; }
        public string Representante { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Tipodoc { get; set; }
        public string Ruc { get; set; } 
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public int Tipo_Contribuyente { get; set; }
        public string Correo { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Parroquia { get; set; }
        public string Sector { get; set; }
        public string Zona { get; set; }
        public string Categoria { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Tipo_Negocio { get; set; }
        public string Medio_Pago { get; set; }
        public string Ruta_Entrega { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Ultimacompra { get; set; }
        public bool Dvlu { get; set; }
        public bool Dvma { get; set; }
        public bool Dvmi { get; set; }
        public bool Dvju { get; set; }
        public bool Dvvi { get; set; }
        public bool Dvsa { get; set; }
        public bool Dvdo { get; set; }
        public string Frecuencia { get; set; }
        public int Orden { get; set; }
        public int Vendedor { get; set; }
        public int Vendedor_Aux { get; set; }
        public int Dias_Credito { get; set; }
        public bool Credito { get; set; }
        public float Cupo { get; set; }
        public float Extra_Cupo { get; set; }
        public bool Estado { get; set; }
        public string Clavefe { get; set; }
        public string Sexo { get; set; }
        public bool Relacionado { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public bool? PrecioAlCosto { get; set; }
        public float? PorcentajeIncremento { get; set; }


    }
}
