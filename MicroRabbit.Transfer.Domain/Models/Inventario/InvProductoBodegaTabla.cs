

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class InvProductoBodegaTabla
    {
        public int Bodega { get; set; }
        public int Producto { get; set; }
        public float Stock { get; set; }
        public float StockReservado { get; set; }
        public DateTime Fecha_Ult_Ing { get; set; }
        public DateTime Fecha_Ult_Egr { get; set; }
        public string Lote { get; set; }
        public DateTime Fecha_Ven { get; set; }
        public DateTime Fecha_Ela { get; set; }


    }
}
