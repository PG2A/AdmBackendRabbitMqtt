using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events.Inventario
{
    public class CamionCreateEvent : Event
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public float Volumen { get; set; }
        public int Anio { get; set; }
        public float Peso { get; set; }
        public int Chofer { get; set; }
        public string? Nombrechofer { get; set; }
        public string? Nombresucursal { get; set; }
        public bool? Estado { get; set; }
        public string? Detalle { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
        public int Sucursal { get; set; }

        public CamionCreateEvent(int codigo, string nombre, string placa, float volumen, int anio, float peso, int chofer, string? nombrechofer, string? nombresucursal, bool? estado, string? detalle, DateTime fecha_Ingreso, string? maquina, int usuario, int sucursal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Placa = placa;
            Volumen = volumen;
            Anio = anio;
            Peso = peso;
            Chofer = chofer;
            Nombrechofer = nombrechofer;
            Nombresucursal = nombresucursal;
            Estado = estado;
            Detalle = detalle;
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
