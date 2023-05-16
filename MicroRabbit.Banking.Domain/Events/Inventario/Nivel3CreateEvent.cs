using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Banking.Domain.Events.Inventario
{
    public class Nivel3CreateEvent : Event
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string Nivel1 { get; set; }
        public string Nivel2 { get; set; }
        public string? Nombre_nivel1 { get; set; }
        public string? Nombre_nivel2 { get; set; }
        public string? EstadoString => Estado ? "A" : "I";
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public int Sucursal { get; set; }

        public Nivel3CreateEvent(string codigo, string nombre, bool estado, string nivel1, string nivel2,  DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
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
