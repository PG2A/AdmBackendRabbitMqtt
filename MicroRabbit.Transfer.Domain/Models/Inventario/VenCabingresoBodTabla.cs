

using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class VenCabingresoBodTabla
    {
        [Key]
        public string Codigo { get; set; }

        public int Sucursal { get; set; }

        public string Tipo { get; set; }

        public string? Serie { get; set; }

        public int Numero { get; set; }

        public int Bodega { get; set; }

        public string? Cliente { get; set; }

        public DateTime Fechaemi { get; set; }

        public DateTime? Fechaent { get; set; }

        public int? Bodegaorigen { get; set; }

        public int? Vendedor { get; set; }

        public int? Proveedor { get; set; }

        public double? Peso { get; set; }

        public double? Volumen { get; set; }

        public string? Motivo { get; set; }

        public string? Observacion { get; set; }

        public string? Comentario { get; set; }

        public string? Seccontable { get; set; }

        public string? Estado { get; set; }

        public string? Estadodoc { get; set; }

        public bool? Enviadosri { get; set; }

        public string? Numautorizacion { get; set; }

        public string? Codigorel { get; set; }

        public DateTime Fecha_ing { get; set; }

        public string Maquina { get; set; }

        public int Usuario { get; set; }
    }
}
