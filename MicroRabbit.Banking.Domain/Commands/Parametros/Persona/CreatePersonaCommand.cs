using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Parametros.Persona
{
    public class CreatePersonaCommand : PersonaCommand
    {
        public CreatePersonaCommand(int codigo, string? codigo_Usuario, string? tipo_persona, string? nombre, string? apellido, string? cedula, string? direccion, string? celular, string? correo, string? observacion, bool? estado, bool? claveMaestra, int? usuariomaq, string? maquina, string? clave, string tipopeticion)
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
