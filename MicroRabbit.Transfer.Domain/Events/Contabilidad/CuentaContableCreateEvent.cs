using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events.Contabilidad
{
    public class CuentaContableCreateEvent : Event
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
        public DateTime Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public string TipoPeticion { get; set; }

        public CuentaContableCreateEvent(int anio, string cuenta, string nombre, string naturaleza, bool auxiliar, string cuentamayor, string grupo, string subgrupo, decimal deb0, decimal cre0, decimal saldo0, decimal deb1, decimal cre1, decimal saldo1, decimal deb2, decimal cre2, decimal saldo2, decimal deb3, decimal cre3, decimal saldo3, decimal deb4, decimal cre4, decimal saldo4, decimal deb5, decimal cre5, decimal saldo5, decimal deb6, decimal cre6, decimal saldo6, decimal deb7, decimal cre7, decimal saldo7, decimal deb8, decimal cre8, decimal saldo8, decimal deb9, decimal cre9, decimal saldo9, decimal deb10, decimal cre10, decimal saldo10, decimal deb11, decimal cre11, decimal saldo11, decimal deb12, decimal cre12, decimal saldo12, decimal deb13, decimal cre13, decimal saldo13, int? centrodeCosto, DateTime fecha_Ingreso, string maquina, int usuario, string tipoPeticion)
        {
            Anio = anio;
            Cuenta = cuenta;
            Nombre = nombre;
            Naturaleza = naturaleza;
            Auxiliar = auxiliar;
            Cuentamayor = cuentamayor;
            Grupo = grupo;
            Subgrupo = subgrupo;
            Deb0 = deb0;
            Cre0 = cre0;
            Saldo0 = saldo0;
            Deb1 = deb1;
            Cre1 = cre1;
            Saldo1 = saldo1;
            Deb2 = deb2;
            Cre2 = cre2;
            Saldo2 = saldo2;
            Deb3 = deb3;
            Cre3 = cre3;
            Saldo3 = saldo3;
            Deb4 = deb4;
            Cre4 = cre4;
            Saldo4 = saldo4;
            Deb5 = deb5;
            Cre5 = cre5;
            Saldo5 = saldo5;
            Deb6 = deb6;
            Cre6 = cre6;
            Saldo6 = saldo6;
            Deb7 = deb7;
            Cre7 = cre7;
            Saldo7 = saldo7;
            Deb8 = deb8;
            Cre8 = cre8;
            Saldo8 = saldo8;
            Deb9 = deb9;
            Cre9 = cre9;
            Saldo9 = saldo9;
            Deb10 = deb10;
            Cre10 = cre10;
            Saldo10 = saldo10;
            Deb11 = deb11;
            Cre11 = cre11;
            Saldo11 = saldo11;
            Deb12 = deb12;
            Cre12 = cre12;
            Saldo12 = saldo12;
            Deb13 = deb13;
            Cre13 = cre13;
            Saldo13 = saldo13;
            CentrodeCosto = centrodeCosto;
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
            TipoPeticion = tipoPeticion;
        }
    }
}
