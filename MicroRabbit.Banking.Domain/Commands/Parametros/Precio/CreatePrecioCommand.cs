using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Parametros.Precio
{
    public class CreatePrecioCommand : PrecioCommand
    {
        public CreatePrecioCommand(int codigo, int? sucursal, int? tipo, float? precio, int? producto, DateTime? fecha_ing, string? maquina, int? usuario, float? porDes, string? tipoPeticion)
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
