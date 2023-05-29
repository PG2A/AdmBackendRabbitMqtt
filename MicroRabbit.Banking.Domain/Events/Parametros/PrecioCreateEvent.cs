using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.Parametros
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

        public PrecioCreateEvent(int codigo, int? sucursal, int? tipo, float? precio, int? producto, DateTime? fecha_ing, string? maquina, int? usuario, float? porDes, string? tipoPeticion)
        {
            Codigo = codigo;
            Sucursal = sucursal;
            Tipo = tipo;
            Precio = precio;
            Producto = producto;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            PorDes = porDes;
            TipoPeticion = tipoPeticion;
        }
    }
}
