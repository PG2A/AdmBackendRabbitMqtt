namespace MicroRabbit.Banking.Application.Models.Inventario
{
    public class ChoferModel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Observacion { get; set; }
        public bool? Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string? Detalle { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
        public int Sucursal { get; set; }
        public string? TipoPeticion { get; set; }
    }
}
