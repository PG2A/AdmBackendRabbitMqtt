using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.Inventario
{
    public class ChoferCreateEvent : Event
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Observacion { get; set; }
        public bool? Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string? Detalle { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
        public int Sucursal { get; set; }
        public string TipoPeticion { get; set; }

        public ChoferCreateEvent(int codigo, string nombre, string cedula, string direccion, string celular, string observacion, bool? estado, DateTime fecha_Ingreso, string? detalle, string? maquina, int usuario, int sucursal, string tipoPeticion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
            Celular = celular;
            Observacion = observacion;
            Estado = estado;
            Fecha_Ingreso = fecha_Ingreso;
            Detalle = detalle;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
            TipoPeticion = tipoPeticion;
        }
    }
}
