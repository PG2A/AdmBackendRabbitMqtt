namespace MicroRabbit.Banking.Domain.Models.Inventario
{
    public class TransferenciaBodegaDetModel
    {
        public string? Codigo { get; set; }
        public int Id_producto { get; set; }
        public int Linea { get; set; }
        public string Marca { get; set; }
        public int Producto { get; set; }
        public float Caja { get; set; }
        public float Unidad { get; set; }
        public float Totalfun { get; set; }
        public float Factor { get; set; }
        public float? CostoP { get; set; }
        public float? CostoU { get; set; }
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
        public string Detalle { get; set; }
        public char Formavta { get; set; }
        public float? Cantdevo { get; set; }
        public float? Cantconfirmada { get; set; }
        public float Unidadestotales { get; set; }
        public int Bodega { get; set; }
        public int Bodegao { get; set; }

        public TransferenciaBodegaDetModel(string? codigo, int id_producto, int linea, string marca, int producto, float caja, float unidad, float totalfun, float factor, float? costoP, float? costoU, float precio, bool pagaiva, float poriva, float subtotal, float? pordes, float descuento, float iva, float neto, string? lote, DateTime? fechaela, DateTime? fechaven, string detalle, char formavta, float? cantdevo, float? cantconfirmada, float unidadestotales, int bodega, int bodegao)
        {
            Codigo = codigo;
            Id_producto = id_producto;
            Linea = linea;
            Marca = marca;
            Producto = producto;
            Caja = caja;
            Unidad = unidad;
            Totalfun = totalfun;
            Factor = factor;
            CostoP = costoP;
            CostoU = costoU;
            Precio = precio;
            Pagaiva = pagaiva;
            Poriva = poriva;
            Subtotal = subtotal;
            Pordes = pordes;
            Descuento = descuento;
            Iva = iva;
            Neto = neto;
            Lote = lote;
            Fechaela = fechaela;
            Fechaven = fechaven;
            Detalle = detalle;
            Formavta = formavta;
            Cantdevo = cantdevo;
            Cantconfirmada = cantconfirmada;
            Unidadestotales = unidadestotales;
            Bodega = bodega;
            Bodegao = bodegao;
        }
    }
}
