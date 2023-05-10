using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel1;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateNivel1Command: Nivel1Commands
    {
    
        public CreateNivel1Command(string codigo, string nombre, bool estado, DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
