using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.Inventario
{
    public class MotivosInventarioCreateEvent : Event
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

        public MotivosInventarioCreateEvent(string codigo, string? nombre, string? cuenta, bool? estadistica, bool? sri, string? tipoDocInventario, bool? estado, DateTime? fecha_ing, string? maquina, int? usuario, string tipoPeticion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cuenta = cuenta;
            Estadistica = estadistica;
            Sri = sri;
            TipoDocInventario = tipoDocInventario;
            Estado = estado;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            TipoPeticion = tipoPeticion;
        }
    }
}
