using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Inventario.Camion
{
    public class CreateCamionCommand : CamionCommand
    {
        public CreateCamionCommand(int codigo, string nombre, string placa, float volumen, int anio, float peso, int chofer, string? nombrechofer, string? nombresucursal, bool? estado, string? detalle, DateTime fecha_Ingreso, string? maquina, int usuario, int sucursal)
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
