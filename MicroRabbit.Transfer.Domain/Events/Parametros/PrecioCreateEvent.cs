using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events.Parametros
{
    public class PrecioCreateEvent : Event
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
    }
}
