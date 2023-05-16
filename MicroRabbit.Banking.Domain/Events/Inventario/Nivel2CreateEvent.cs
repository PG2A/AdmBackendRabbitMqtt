using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Banking.Domain.Events.Inventario
{
    public class Nivel2CreateEvent : Event
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string Nivel1 { get; set; }
        public string? Nombre_nivel1 { get; set; }
        public string? EstadoString => Estado ? "A" : "I";
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public int Sucursal { get; set; }

        public Nivel2CreateEvent(string codigo, string nombre, bool estado, string nivel1, string? nombre_nivel1, DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Estado = estado;
            Nivel1 = nivel1;
            Nombre_nivel1 = nombre_nivel1;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
