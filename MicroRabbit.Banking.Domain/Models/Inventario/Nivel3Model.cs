﻿

namespace MicroRabbit.Banking.Domain.Models.Inventario
{
    public class Nivel3Model
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
    }
}
