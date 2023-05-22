using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Inventario.MotivosInventario
{
    public class CreateMotivosInventarioCommand : MotivosInventarioCommand
    {
        public CreateMotivosInventarioCommand(string codigo, string? nombre, string? cuenta, bool? estadistica, bool? sri, string? tipoDocInventario, bool? estado, DateTime? fecha_ing, string? maquina, int? usuario, string tipopeticion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cuenta = cuenta;
            Estadistica = estadistica;
            Sri = sri;
            TipoDocInventario = tipoDocInventario;
            Estado = estado;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            TipoPeticion = tipopeticion;
        }
    }
}
