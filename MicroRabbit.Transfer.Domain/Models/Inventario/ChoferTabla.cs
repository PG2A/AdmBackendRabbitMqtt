using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class ChoferTabla
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string? Observacion { get; set; }
        public bool? Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
    }
}
