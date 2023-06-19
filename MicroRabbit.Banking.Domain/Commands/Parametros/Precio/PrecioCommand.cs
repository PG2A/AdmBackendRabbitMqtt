using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Parametros.Precio
{
    public class PrecioCommand : Command
    {
        public int Codigo { get; set; }
        public int? Sucursal { get; set; }
        public int? Tipo { get; set; }
        public float? Precio { get; set; }
        public int? Producto { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public float? PorDes { get; set; }
        public string? TipoPeticion { get; set; }
        public int? TodasSucursales { get; set; }
    }
}
