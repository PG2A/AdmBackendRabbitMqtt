using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events.Inventario
{
    public class ProductoCreateEvent : Event
    {
        public int Codigo { get; set; }
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
        public bool Pagaiva { get; set; }
        public decimal Poriva { get; set; }
        public bool Dispoventa { get; set; }
        public bool Regalo { get; set; }
        public bool Combo { get; set; }
        public char Bien { get; set; }
        public bool Estado { get; set; }
        public decimal Costou { get; set; }
        public decimal Costop { get; set; }
        public decimal Pvp { get; set; }
        public string Principio_Activo { get; set; }
        public string Laboratorio { get; set; }
        public string Observacion { get; set; }
        public bool EsRubro { get; set; }
        public string Cuenta { get; set; }
        public bool ControlLote { get; set; }
        public bool SoloReceta { get; set; }
        public bool TraContinuo { get; set; }
        public bool Psicotropico { get; set; }
        public string? RegSanitario { get; set; }
        public string? Concentracion { get; set; }
        public string? FormaFarmaceutica { get; set; }
        public string? PresentacionFarmacion { get; set; }
        public float? Pvf { get; set; }
        public float PorDes { get; set; }
        public string ClaseTerapeuta { get; set; }
        public DateTime? Fecha_Ingreso { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public string TipoPeticion { get; set; }

        public ProductoCreateEvent(int codigo, string codigo_Producto, int sucursal, string codigo_Barra, string codigo_Barra2, string nombre, string nombre_Extra, string marca, string presentacion, string nivel1, string nivel2, string nivel3, int proveedor, int factor, bool pagaiva, decimal poriva, bool dispoventa, bool regalo, bool combo, char bien, bool estado, decimal costou, decimal costop, decimal pvp, string principio_Activo, string laboratorio, string observacion, bool esRubro, string cuenta, bool controlLote, bool soloReceta, bool traContinuo, bool psicotropico, string? regSanitario, string? concentracion, string? formaFarmaceutica, string? presentacionFarmacion, float? pvf, float porDes, string claseTerapeuta, DateTime? fecha_Ingreso, string maquina, int usuario, string tipoPeticion)
        {
            Codigo = codigo;
            Codigo_Producto = codigo_Producto;
            Sucursal = sucursal;
            Codigo_Barra = codigo_Barra;
            Codigo_Barra2 = codigo_Barra2;
            Nombre = nombre;
            Nombre_Extra = nombre_Extra;
            Marca = marca;
            Presentacion = presentacion;
            Nivel1 = nivel1;
            Nivel2 = nivel2;
            Nivel3 = nivel3;
            Proveedor = proveedor;
            Factor = factor;
            Pagaiva = pagaiva;
            Poriva = poriva;
            Dispoventa = dispoventa;
            Regalo = regalo;
            Combo = combo;
            Bien = bien;
            Estado = estado;
            Costou = costou;
            Costop = costop;
            Pvp = pvp;
            Principio_Activo = principio_Activo;
            Laboratorio = laboratorio;
            Observacion = observacion;
            EsRubro = esRubro;
            Cuenta = cuenta;
            ControlLote = controlLote;
            SoloReceta = soloReceta;
            TraContinuo = traContinuo;
            Psicotropico = psicotropico;
            RegSanitario = regSanitario;
            Concentracion = concentracion;
            FormaFarmaceutica = formaFarmaceutica;
            PresentacionFarmacion = presentacionFarmacion;
            Pvf = pvf;
            PorDes = porDes;
            ClaseTerapeuta = claseTerapeuta;
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
            TipoPeticion = tipoPeticion;
        }
    }
}
