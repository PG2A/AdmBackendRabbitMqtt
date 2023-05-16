using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Inventario.Chofer
{
    public class CreateChoferCommand : ChoferCommand
    {
        public CreateChoferCommand(int codigo, string nombre, string cedula, string direccion, string celular, string observacion, bool? estado, DateTime fecha_Ingreso, string? detalle, string? maquina, int usuario, int sucursal) {
            Codigo = codigo;
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
            Celular = celular;
            Observacion = observacion;
            Estado = estado;
            Fecha_Ingreso = fecha_Ingreso;
            Detalle = detalle;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
