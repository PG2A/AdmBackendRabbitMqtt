

namespace MicroRabbit.Banking.Domain.Commands.Inventario.Nivel3
{
    public class CreateNivel3Command: Nivel3Command
    {
        public CreateNivel3Command(string codigo, string nombre, bool estado, string nivel1, string nivel2,  DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
            Nivel1 = nivel1;
            Nivel2 = nivel2;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
            

        }
    }
}
