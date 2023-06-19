using MicroRabbit.Banking.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Models.Inventario
{
    public class AjusteEgresoModel
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public int Sucursal { get; set; }
        public string Tipo { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public int Bodega { get; set; }
        public int? Numpedido { get; set; }
        public int? Numguia { get; set; }
        public string? Cliente { get; set; }
        public DateTime Fechaemi { get; set; }
        public DateTime Fechaven { get; set; }
        public DateTime? Fechaent { get; set; }
        public int? Bodegadestino { get; set; }
        public int? Vendedor { get; set; }
        public int? Proveedor { get; set; }
        public float? Peso { get; set; }
        public float? Volumen { get; set; }
        public string? Motivo { get; set; }
        public string? Observacion { get; set; }
        public string? Comentario { get; set; }
        public string? Seccontable { get; set; }
        public char? Estado { get; set; }
        public string? Estadodoc { get; set; }
        public bool? Enviadosri { get; set; }
        public string? Numautorizacion { get; set; }
        public string? Codigorel { get; set; }
        public DateTime Fecha_ing { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public bool PagaIva { get; set; }
        public float? Iva { get; set; }
        public float? Subt0 { get; set; }
        public float? Subt12 { get; set; }
        public float? Subtotal { get; set; }
        public float? Total { get; set; }
        public float? Factor { get; set; }
        public string? ClaseAjuste { get; set; }
        public bool? Credito { get; set; }
        public  List<AjusteEgresoDetModel>? Productos { get; set; }
    }
}
