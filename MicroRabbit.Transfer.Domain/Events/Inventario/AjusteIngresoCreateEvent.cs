

using MicroRabbit.Domain.Core.Events;
using MicroRabbit.Transfer.Domain.Events.ModelsEvent;

namespace MicroRabbit.Transfer.Domain.Events.Inventario
{
    public class AjusteIngresoCreateEvent : Event
    {
        public string Codigo { get; set; }
        public int Sucursal { get; set; }
        public string Tipo { get; set; }
        public string? Serie { get; set; }
        public int? Numero { get; set; }
        public int Bodega { get; set; }
        public string? Cliente { get; set; }
        public DateTime Fechaemi { get; set; }
        public DateTime? Fechaent { get; set; }
        public int? Bodegaorigen { get; set; }
        public int? Vendedor { get; set; }
        public int Proveedor { get; set; }
        public float? Peso { get; set; }
        public float? Volumen { get; set; }
        public string? Motivo { get; set; }
        public string? Observacion { get; set; }
        public string? Comentario { get; set; }
        public string Seccontable { get; set; }
        public string? Estado { get; set; }
        public string? Estadodoc { get; set; }
        public int? Enviadosri { get; set; }
        public int? Numautorizacion { get; set; }
        public string? Codigorel { get; set; }
        public DateTime? Fecha_ing { get; set; }
        public string? Maquina { get; set; }
        public int Usuario { get; set; }
        public string? ClaseAjuste { get; set; }
        public virtual List<AjusteIngresoDetModel>? Productos { get; set; }

        public AjusteIngresoCreateEvent(string codigo, int sucursal, string tipo, string? serie, int? numero, int bodega, string? cliente, DateTime fechaemi, DateTime? fechaent, int? bodegaorigen, int? vendedor, int proveedor, float? peso, float? volumen, string? motivo, string? observacion, string? comentario, string seccontable, string? estado, string? estadodoc, int? enviadosri, int? numautorizacion, string? codigorel, DateTime? fecha_ing, string? maquina, int usuario, string? claseAjuste, List<AjusteIngresoDetModel>? productos)
        {
            Codigo = codigo;
            Sucursal = sucursal;
            Tipo = tipo;
            Serie = serie;
            Numero = numero;
            Bodega = bodega;
            Cliente = cliente;
            Fechaemi = fechaemi;
            Fechaent = fechaent;
            Bodegaorigen = bodegaorigen;
            Vendedor = vendedor;
            Proveedor = proveedor;
            Peso = peso;
            Volumen = volumen;
            Motivo = motivo;
            Observacion = observacion;
            Comentario = comentario;
            Seccontable = seccontable;
            Estado = estado;
            Estadodoc = estadodoc;
            Enviadosri = enviadosri;
            Numautorizacion = numautorizacion;
            Codigorel = codigorel;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            ClaseAjuste = claseAjuste;
            Productos = productos;
        }
    }
}
