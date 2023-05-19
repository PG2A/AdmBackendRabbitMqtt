using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class MotivosInventarioTabla
    {
        [Key]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cuenta { get; set; }
        public bool Estadistica { get; set; }
        public bool Sri { get; set; }
        public string TipoDocInventario { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_ing { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
    }
}
