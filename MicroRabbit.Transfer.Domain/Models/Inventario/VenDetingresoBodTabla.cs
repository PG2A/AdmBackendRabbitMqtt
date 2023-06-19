using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class VenDetingresoBodTabla
    {
        [Key]
        public string Codigo { get; set; } = null!;

        public int Linea { get; set; }

        public int Producto { get; set; }

        public double Caja { get; set; }

        public double Unidad { get; set; }

        public double Totalfun { get; set; }

        public double? Factor { get; set; }

        public double? CostoP { get; set; }

        public double? CostoU { get; set; }

        public double? Precio { get; set; }

        public bool Pagaiva { get; set; }

        public double Poriva { get; set; }

        public decimal Subtotal { get; set; }

        public double Pordes { get; set; }

        public decimal Descuento { get; set; }

        public decimal Iva { get; set; }

        public decimal Neto { get; set; }

        public string? Lote { get; set; }

        public DateTime? Fechaela { get; set; }

        public DateTime? Fechaven { get; set; }

        public string? Detalle { get; set; }
    }
}
