using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Models.Parametros
{
    public class PesonaModel
    {
        public int Codigo { get; set; }
        public string Codigo_Usuario { get; set; }
        public string Tipo_persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
        public string? Observacion { get; set; }
        public bool Estado { get; set; }
        public bool? ClaveMaestra { get; set; }
        public int Usuariomaq { get; set; }
        public string Maquina { get; set; }
        public string Clave { get; set; }
    }
}
