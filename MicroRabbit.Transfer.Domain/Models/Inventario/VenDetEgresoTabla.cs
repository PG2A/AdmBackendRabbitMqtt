using System.ComponentModel.DataAnnotations;


namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class VenDetEgresoTabla
    {
        [Key]
        public string Codigo { get; set; }
        public int Linea { get; set; }
        public int Producto { get; set; }
        public float Caja { get; set; }
        public float Unidad { get; set; }
        public float Totalfun { get; set; }
        public float Factor { get; set; }
        public float CostoP { get; set; }
        public float CostoU { get; set; }
        public float Precio { get; set; }
        public bool Pagaiva { get; set; }
        public float Poriva { get; set; }
        public float Subtotal { get; set; }
        public float? Pordes { get; set; }
        public float Descuento { get; set; }
        public float Iva { get; set; }
        public float Neto { get; set; }
        public string? Lote { get; set; }
        public DateTime? Fechaela { get; set; }
        public DateTime? Fechaven { get; set; }
        public string? Detalle { get; set; }
        public char? Formavta { get; set; }
        public float? Cantdevo { get; set; }
        public float? Cantconfirmada { get; set; }
        public bool Reversa { get; set; }
        public bool ConfirmaReversa { get; set; }
        public float? CantCancelada { get; set; }
    }
}
