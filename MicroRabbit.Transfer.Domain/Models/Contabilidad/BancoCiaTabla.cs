using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Contabilidad
{
    public class BancoCiaTabla
    {
        [Key]
        public int Codigo { get; set; }
        public string Inicial_Banco { get; set; }
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Numero_Cuenta { get; set; }
        public int Ultimo_Cheque { get; set; }
        public string? Tipo_Cuenta { get; set; }
        public int Anio { get; set; }
        public bool Contador_Automatico { get; set; }
        public string Cuenta_Cheque_Fecha { get; set; }
        public bool Estado { get; set; }
        public DateTime? Ultima_Conciliacion { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
    }
}
