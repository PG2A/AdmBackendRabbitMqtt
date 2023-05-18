using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Contabilidad
{
    public class CuentaContableTabla
    {
        [Key]
        public int Anio { get; set; }
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Naturaleza { get; set; }
        public bool Auxiliar { get; set; }
        public string Cuentamayor { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
       // public decimal Deb0 { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
    }
}
