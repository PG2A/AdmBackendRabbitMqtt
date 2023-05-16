

namespace MicroRabbit.Banking.Domain.Commands.Inventario.Nivel2
{
    public class CreateNivel2Command : Nivel2Command
    {
        public CreateNivel2Command(string codigo, string nombre, bool estado, string nivel1 ,DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
            Nivel1 = nivel1;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
