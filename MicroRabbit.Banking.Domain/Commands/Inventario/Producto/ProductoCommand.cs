using MicroRabbit.Domain.Core.Commands;


namespace MicroRabbit.Banking.Domain.Commands.Inventario.Producto
{
    public class ProductoCommand : Command
    {
        public int? Codigo { get; set; }
        public string Codigo_Producto { get; set; }
        public int Sucursal { get; set; }
        public string Codigo_Barra { get; set; }
        public string Codigo_Barra2 { get; set; }
        public string Nombre { get; set; }
        public string Nombre_Extra { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }
        public string Nivel1 { get; set; }
        public string Nivel2 { get; set; }
        public string Nivel3 { get; set; }
        public int Proveedor { get; set; }
        public int Factor { get; set; }
        public Boolean Pagaiva { get; set; }
        public decimal Poriva { get; set; }
        public Boolean Dispoventa { get; set; }
        public Boolean Regalo { get; set; }
        public Boolean Combo { get; set; }
        public char Bien { get; set; }
        public Boolean Estado { get; set; }
        public decimal Costou { get; set; }
        public decimal Costop { get; set; }
        public decimal Pvp { get; set; }
        public string Principio_Activo { get; set; }
        public string Laboratorio { get; set; }
        public string Observacion { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public string? Nivel1_Nombre { get; set; }
        public string? Nivel2_Nombre { get; set; }
        public string? Nivel3_Nombre { get; set; }
        public string? Nombremarca { get; set; }
        public string? Nombre_Proveedor { get; set; }
        public string? Nombre_Presentacion { get; set; }
        public string? Cuenta { get; set; }
        public float? Pvf { get; set; }
        public float PorDes { get; set; }
        public string ClaseTerapeuta { get; set; }
        public string NombreClaseTerapeuta { get; set; }
        public Boolean ControlLote { get; set; }
        public Boolean SoloReceta { get; set; }
        public Boolean TraContinuo { get; set; }
        public Boolean Psicotropico { get; set; }
        public string? RegSanitario { get; set; }
        public string? Concentracion { get; set; }
        public string? FormaFarmaceutica { get; set; }
        public string? PresentacionFarmacion { get; set; }
        public float? StockPorBodega { get; set; }
        public double? Precio { get; set; }
        public double? StockGeneral { get; set; }
        public float? StockMatriz { get; set; }

    }
}
