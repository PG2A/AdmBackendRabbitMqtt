using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Contabilidad.CuentaContable
{
    public class CuentaContableCommand : Command
    {
        public int Anio { get; set; }
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Naturaleza { get; set; }
        public bool Auxiliar { get; set; }
        public string Cuentamayor { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
        public decimal Deb0 { get; set; } = 0;
        public decimal Cre0 { get; set; } = 0;
        public decimal Saldo0 { get; set; } = 0;
        public decimal Deb1 { get; set; } = 0;
        public decimal Cre1 { get; set; } = 0;
        public decimal Saldo1 { get; set; } = 0;
        public decimal Deb2 { get; set; } = 0;
        public decimal Cre2 { get; set; } = 0;
        public decimal Saldo2 { get; set; } = 0;
        public decimal Deb3 { get; set; } = 0;
        public decimal Cre3 { get; set; } = 0;
        public decimal Saldo3 { get; set; } = 0;
        public decimal Deb4 { get; set; } = 0;
        public decimal Cre4 { get; set; } = 0;
        public decimal Saldo4 { get; set; } = 0;
        public decimal Deb5 { get; set; } = 0;
        public decimal Cre5 { get; set; } = 0;
        public decimal Saldo5 { get; set; } = 0;
        public decimal Deb6 { get; set; } = 0;
        public decimal Cre6 { get; set; } = 0;
        public decimal Saldo6 { get; set; } = 0;
        public decimal Deb7 { get; set; } = 0;
        public decimal Cre7 { get; set; } = 0;
        public decimal Saldo7 { get; set; } = 0;
        public decimal Deb8 { get; set; } = 0;
        public decimal Cre8 { get; set; } = 0;
        public decimal Saldo8 { get; set; } = 0;
        public decimal Deb9 { get; set; } = 0;
        public decimal Cre9 { get; set; } = 0;
        public decimal Saldo9 { get; set; } = 0;
        public decimal Deb10 { get; set; } = 0;
        public decimal Cre10 { get; set; } = 0;
        public decimal Saldo10 { get; set; } = 0;
        public decimal Deb11 { get; set; } = 0;
        public decimal Cre11 { get; set; } = 0;
        public decimal Saldo11 { get; set; } = 0;
        public decimal Deb12 { get; set; } = 0;
        public decimal Cre12 { get; set; } = 0;
        public decimal Saldo12 { get; set; } = 0;
        public decimal Deb13 { get; set; } = 0;
        public decimal Cre13 { get; set; } = 0;
        public decimal Saldo13 { get; set; } = 0;
        public int? CentrodeCosto { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public string TipoPeticion { get; set; }
    }
}
