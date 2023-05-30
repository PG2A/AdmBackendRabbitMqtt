using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events.Parametros
{
    public class BodegaCreateEvent : Event
    {
        public int Codigo { get; set; }
        public int Sucursal { get; set; }
        public string Codigo_Bodega { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Responsable { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }

        public BodegaCreateEvent(int codigo, int sucursal, string codigo_Bodega, string nombre, string direccion, string responsable, string telefono, string correo, bool estado, DateTime fecha_Ingreso, string maquina, int usuario)
        {
            Codigo = codigo;
            Sucursal = sucursal;
            Codigo_Bodega = codigo_Bodega;
            Nombre = nombre;
            Direccion = direccion;
            Responsable = responsable;
            Telefono = telefono;
            Correo = correo;
            Estado = estado;
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
        }
    }
}
