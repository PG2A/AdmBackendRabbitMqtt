using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.Contabilidad
{
    public class BancoCiaCreateEvent : Event
    {
        public int Codigo { get; set; }
        public string Inicial_Banco { get; set; }
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Numero_Cuenta { get; set; }
        public string? Nombre_cuenta { get; set; }
        public int Ultimo_Cheque { get; set; }
        public string? Tipo_Cuenta { get; set; }
        public int Anio { get; set; }
        public bool Contador_Automatico { get; set; }
        public string? Contador_AutomaticoString => Contador_Automatico ? "A" : "I";
        public string Cuenta_Cheque_Fecha { get; set; }
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

        public BancoCiaCreateEvent(int codigo, string inicial_Banco, string cuenta, string nombre, string numero_Cuenta, string? nombre_cuenta, int ultimo_Cheque, string? tipo_Cuenta, int anio, bool contador_Automatico, string cuenta_Cheque_Fecha, string? nombre_cta_cheque, bool estado, DateTime? ultima_Conciliacion, DateTime? fecha_ing, DateTime? fechaRegistro, string? detalle, string? maquina, DateTime? fecha, int? usuario, int? sucursal)
        {
            Codigo = codigo;
            Inicial_Banco = inicial_Banco;
            Cuenta = cuenta;
            Nombre = nombre;
            Numero_Cuenta = numero_Cuenta;
            Nombre_cuenta = nombre_cuenta;
            Ultimo_Cheque = ultimo_Cheque;
            Tipo_Cuenta = tipo_Cuenta;
            Anio = anio;
            Contador_Automatico = contador_Automatico;
            Cuenta_Cheque_Fecha = cuenta_Cheque_Fecha;
            Nombre_cta_cheque = nombre_cta_cheque;
            Estado = estado;
            Ultima_Conciliacion = ultima_Conciliacion;
            Fecha_ing = fecha_ing;
            FechaRegistro = fechaRegistro;
            Detalle = detalle;
            Maquina = maquina;
            Fecha = fecha;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
