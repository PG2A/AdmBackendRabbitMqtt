
using System.ComponentModel.DataAnnotations;


namespace MicroRabbit.Transfer.Domain.Models
{
    public class Nivel1Tabla
    {
        [Key]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        
    }
}
