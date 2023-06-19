using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Transfer.Domain.Models.Parametros
{
    public class PrecioTabla
    {
        [Key]
        public int Codigo { get; set; }
        public int Sucursal { get; set; }
        public int Tipo { get; set; }
        public float Precio { get; set; }
        public int Producto { get; set; }
        public DateTime Fecha_ing { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public float PorDes { get; set; }
    }
}
