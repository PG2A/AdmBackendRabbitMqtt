

namespace MicroRabbit.Transfer.Domain.Events.ModelsEvent
{
    public class AjusteIngresoDetModel
    {
        public string Codigo { get; set; }
        public int Linea { get; set; }
        public int Producto { get; set; }
        public float Caja { get; set; }
        public float Unidad { get; set; }
        public float? Totalfun { get; set; }
        public float Factor { get; set; }
        public float? CostoP { get; set; }
        public float? CostoU { get; set; }
        public float? Precio { get; set; }
        public bool Pagaiva { get; set; }
        public float Poriva { get; set; }
        public decimal Subtotal { get; set; }
        public float? Pordes { get; set; }
        public decimal? Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Neto { get; set; }
        public string? Lote { get; set; }
        public DateTime? Fechaela { get; set; }
        public DateTime? Fechaven { get; set; }
        public string? Detalle { get; set; }
        public string? Nombre { get; set; }
        public string? Codigo_Barra { get; set; }
        public float? Pvp { get; set; }
    }
}
