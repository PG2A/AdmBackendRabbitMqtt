

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class VenAgregarStockProductoBodAjusteIngresoProc
    {
        public float Cantidad { get; set; }
        public int Codigo { get; set; }
        public string Lote { get; set; }
        public int Bodega { get; set; }
        public DateTime Fechaela { get; set; }
        public DateTime Fechaven { get; set; }

    }
}
