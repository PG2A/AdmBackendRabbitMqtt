using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.Parametros
{
    public class PersonaCreateEvent : Event
    {
        public int Codigo { get; set; }
        public string? Codigo_Usuario { get; set; }
        public string? Tipo_persona { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Cedula { get; set; }
        public string? Direccion { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
        public string? Observacion { get; set; }
        public bool? Estado { get; set; }
        public bool? ClaveMaestra { get; set; }
        public int? Usuariomaq { get; set; }
        public string? Maquina { get; set; }
        public string? Clave { get; set; }
        public string TipoPeticion { get; set; }

        public PersonaCreateEvent(int codigo, string? codigo_Usuario, string? tipo_persona, string? nombre, string? apellido, string? cedula, string? direccion, string? celular, string? correo, string? observacion, bool? estado, bool? claveMaestra, int? usuariomaq, string? maquina, string? clave, string tipopeticion)
        {
            Codigo = codigo;
            Codigo_Usuario = codigo_Usuario;
            Tipo_persona = tipo_persona;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Celular = celular;
            Correo = correo;
            Observacion = observacion;
            Estado = estado;
            ClaveMaestra = claveMaestra;
            Usuariomaq = usuariomaq;
            Maquina = maquina;
            Clave = clave;
            TipoPeticion = tipopeticion;
        }
    }
}
