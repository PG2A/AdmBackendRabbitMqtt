using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Models.Inventario
{
    public class AjusteEgresoDetModel
    {
        public string Codbarra { get; set; }
        public int Id_Producto { get; set; }
        public string? Codigoproducto { get; set; }
        public string? Bodega { get; set; }
        public string? Bodeganombre { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cajas { get; set; }
        public float Unidades { get; set; }
        public float Preciou { get; set; }
        public float Subtotal { get; set; }
        public float Pordes { get; set; }
        public float Descuento { get; set; }
        public float Neto { get; set; }
        public string Lote { get; set; }
        public DateTime? Fechaven { get; set; }
        public bool PagaIva { get; set; }
        public float Iva { get; set; }
        public float Subt0 { get; set; }
        public float Subt12 { get; set; }
        public float Factor { get; set; }
        public float? CostoP { get; set; }
        public float? CostoU { get; set; }
    }
}
