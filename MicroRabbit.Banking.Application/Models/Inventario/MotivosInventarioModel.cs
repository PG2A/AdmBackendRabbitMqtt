using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Models.Inventario
{
    public class MotivosInventarioModel
    {
        public string Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Cuenta { get; set; }
        public bool? Estadistica { get; set; }
        public bool? Sri { get; set; }
        public string? TipoDocInventario { get; set; }
        public bool? Estado { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public string TipoPeticion { get; set; }
    }
}
