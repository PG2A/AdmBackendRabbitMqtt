using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class ProductosTabla
    {
        [Key]
        public int Codigo { get; set; }
        public string Codigo_Producto { get; set; }
        public int Sucursal { get; set; }
        public string Codigo_Barra { get; set; }
        public string Codigo_Barra2 { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Extra { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }
        public string Nivel1 { get; set; }
        public string Nivel2 { get; set; }
        public string Nivel3 { get; set; }
        public int Proveedor { get; set; }
        public int Factor { get; set; }
        public bool Pagaiva { get; set; }
        public decimal Poriva { get; set; }
        public bool Dispoventa { get; set; }
        public bool Regalo { get; set; }
        public bool Combo { get; set; }
        public char Bien { get; set; }
        public bool Estado { get; set; }
        public decimal Costou { get; set; }
        public decimal Costop { get; set; }
        public decimal Pvp { get; set; }
        public string Principio_Activo { get; set; }
        public string Laboratorio { get; set; }
        public string Observacion { get; set; }
        public bool EsRubro { get; set; }
        public string Cuenta { get; set; }
        public bool ControlLote { get; set; }
        public bool SoloReceta { get; set; }
        public bool TraContinuo { get; set; }
        public bool Psicotropico { get; set; }
        public string? RegSanitario { get; set; }
        public string? Concentracion { get; set; }
        public string? FormaFarmaceutica { get; set; }
        public string? PresentacionFarmacion { get; set; }
        public float? Pvf { get; set; }
        public float PorDes { get; set; }
        public string ClaseTerapeuta { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
    }
}
