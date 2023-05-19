using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Models.Parametros
{
    public class PersonaTabla
    {
        [Key]
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
        public string? Clave { get; set; }
        public bool? Estado { get; set; }
        public bool? ClaveMaestra { get; set; }
    }
}
