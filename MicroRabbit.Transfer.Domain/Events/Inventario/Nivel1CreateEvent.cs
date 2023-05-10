﻿using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class Nivel1CreateEvent : Event
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string? EstadoString => Estado ? "A" : "I";
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int? Usuario { get; set; }
        public int Sucursal { get; set; }

        public Nivel1CreateEvent(string codigo, string nombre, bool estado, DateTime? fecha_ing, string? maquina, int? usuario, int sucursal)
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
