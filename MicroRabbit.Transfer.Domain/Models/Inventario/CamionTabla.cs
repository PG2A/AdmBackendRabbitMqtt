using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Inventario
{
    public class CamionTabla
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public float Volumen { get; set; }
        public int Anio { get; set; }
        public float Peso { get; set; }
        public int Chofer { get; set; }
        public bool? Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
        public int Sucursal { get; set; }
    }
}
