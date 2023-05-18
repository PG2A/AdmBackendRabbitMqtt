using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia
{
    public class BancoCiaCommand : Command
    {
        public int? Codigo { get; set; }
        public string? Inicial_Banco { get; set; }
        public string? Cuenta { get; set; }
        public string? Nombre { get; set; }
        public string? Numero_Cuenta { get; set; }
        public string? Nombre_cuenta { get; set; }
        public int? Ultimo_Cheque { get; set; }
        public string? Tipo_Cuenta { get; set; }
        public int? Anio { get; set; }
        public bool Contador_Automatico { get; set; }
        public string Contador_AutomaticoString => Contador_Automatico ? "A" : "I";
        public string? Cuenta_Cheque_Fecha { get; set; }
        public string? Nombre_cta_cheque { get; set; }
        public bool Estado { get; set; }
        public string? EstadoString => Estado ? "A" : "I";
        public DateTime? Ultima_Conciliacion { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? Detalle { get; set; }
        public string? Maquina { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Usuario { get; set; }
        public int? Sucursal { get; set; }
        public string TipoPeticion { get; set; }
    }
}
