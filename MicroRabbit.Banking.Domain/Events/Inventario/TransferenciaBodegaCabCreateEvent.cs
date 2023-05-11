
using MicroRabbit.Domain.Core.Events;


namespace MicroRabbit.Banking.Domain.Events.Inventario
{
    public class TransferenciaBodegaCabCreateEvent : Event
    {
        public string? Codigo { get; set; }
        public string Origen { get; set; }
        public int Sucursal { get; set; }
        public int? SucursalD { get; set; }
        public string Tipo { get; set; }
        public string Tipoguia { get; set; }
        public string Serie { get; set; }
        public bool Remision { get; set; }
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
        public char Estado { get; set; }
        public string? Estadodoc { get; set; }
        public bool? Enviadosri { get; set; }
        public string? Numautorizacion { get; set; }
        public string? Codigorel { get; set; }
        public DateTime Fecha_ing { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public string DireccionOrigen { get; set; }
        public string Direcciondestino { get; set; }
        public int Camion { get; set; }
        public int Chofer { get; set; }

      //  public virtual List<TransferenciaBodegaDetModel>? Productos { get; set; }

        public TransferenciaBodegaCabCreateEvent(string? codigo, string origen, int sucursal, int? sucursalD, string tipo, string tipoguia, string serie, bool remision, int numero, int bodega, int? numpedido, int? numguia, string? cliente, DateTime fechaemi, DateTime fechaven, DateTime? fechaent, int? bodegadestino, int? vendedor, int? proveedor, float? peso, float? volumen, string? motivo, string? observacion, string? comentario, string? seccontable, char estado, string? estadodoc, bool? enviadosri, string? numautorizacion, string? codigorel, DateTime fecha_ing, string maquina, int usuario, string direccionOrigen, string direcciondestino, int camion, int chofer)
        {
            Codigo = codigo;
            Origen = origen;
            Sucursal = sucursal;
            SucursalD = sucursalD;
            Tipo = tipo;
            Tipoguia = tipoguia;
            Serie = serie;
            Remision = remision;
            Numero = numero;
            Bodega = bodega;
            Numpedido = numpedido;
            Numguia = numguia;
            Cliente = cliente;
            Fechaemi = fechaemi;
            Fechaven = fechaven;
            Fechaent = fechaent;
            Bodegadestino = bodegadestino;
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
            DireccionOrigen = direccionOrigen;
            Direcciondestino = direcciondestino;
            Camion = camion;
            Chofer = chofer;
           // Productos = productos;
        }
    }
}
