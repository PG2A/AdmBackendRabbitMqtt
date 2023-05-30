using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events.Inventario
{
    public class ProductoBodegaCreateEvent : Event
    {
        public int Bodega { get; set; }
        public int Producto { get; set; }
        public float Stock { get; set; }
        public float? StockReservado { get; set; }
        public DateTime? Fecha_Ult_Ing { get; set; }
        public DateTime? Fecha_Ult_Egr { get; set; }
        public string? Lote { get; set; }
        public DateTime? Fecha_Ven { get; set; }
        public DateTime? Fecha_Ela { get; set; }
        public string? TipoPeticion { get; set; }

        public ProductoBodegaCreateEvent(int bodega, int producto, float stock, float? stockReservado, DateTime? fecha_Ult_Ing, DateTime? fecha_Ult_Egr, string? lote, DateTime? fecha_Ven, DateTime? fecha_Ela, string? tipoPeticion)
        {
            Bodega = bodega;
            Producto = producto;
            Stock = stock;
            StockReservado = stockReservado;
            Fecha_Ult_Ing = fecha_Ult_Ing;
            Fecha_Ult_Egr = fecha_Ult_Egr;
            Lote = lote;
            Fecha_Ven = fecha_Ven;
            Fecha_Ela = fecha_Ela;
            TipoPeticion = tipoPeticion;
        }
    }
}
