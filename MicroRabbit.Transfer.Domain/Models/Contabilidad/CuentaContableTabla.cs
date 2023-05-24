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
        public int Anio { get; set; }
        [Key]
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Naturaleza { get; set; }
        public bool Auxiliar { get; set; }
        public string Cuentamayor { get; set; }
        public string Grupo { get; set; }
        public string Subgrupo { get; set; }
        public decimal Deb0 { get; set; }
        public decimal Cre0 { get; set; }
        public decimal Saldo0 { get; set; }
        public decimal Deb1 { get; set; }
        public decimal Cre1 { get; set; }
        public decimal Saldo1 { get; set; }
        public decimal Deb2 { get; set; }
        public decimal Cre2 { get; set; }
        public decimal Saldo2 { get; set; }
        public decimal Deb3 { get; set; }
        public decimal Cre3 { get; set; }
        public decimal Saldo3 { get; set; }
        public decimal Deb4 { get; set; }
        public decimal Cre4 { get; set; }
        public decimal Saldo4 { get; set; }
        public decimal Deb5 { get; set; }
        public decimal Cre5 { get; set; }
        public decimal Saldo5 { get; set; }
        public decimal Deb6 { get; set; }
        public decimal Cre6 { get; set; }
        public decimal Saldo6 { get; set; }
        public decimal Deb7 { get; set; }
        public decimal Cre7 { get; set; }
        public decimal Saldo7 { get; set; }
        public decimal Deb8 { get; set; }
        public decimal Cre8 { get; set; }
        public decimal Saldo8 { get; set; }
        public decimal Deb9 { get; set; }
        public decimal Cre9 { get; set; }
        public decimal Saldo9 { get; set; }
        public decimal Deb10 { get; set; }
        public decimal Cre10 { get; set; }
        public decimal Saldo10 { get; set; }
        public decimal Deb11 { get; set; }
        public decimal Cre11 { get; set; }
        public decimal Saldo11 { get; set; }
        public decimal Deb12 { get; set; }
        public decimal Cre12 { get; set; }
        public decimal Saldo12 { get; set; }
        public decimal Deb13 { get; set; }
        public decimal Cre13 { get; set; }
        public decimal Saldo13 { get; set; }
        public int? CentrodeCosto { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
    }
}
