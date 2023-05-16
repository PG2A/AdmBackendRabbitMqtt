
namespace MicroRabbit.Banking.Domain.Commands.Inventario.Producto
{
    public class CreateProductoCommand : ProductoCommand
    {
        public CreateProductoCommand(int? codigo, string codigo_Producto, int sucursal, string codigo_Barra, string codigo_Barra2, string nombre, string nombre_Extra, string marca, string presentacion, string nivel1, string nivel2, string nivel3, int proveedor, int factor, bool pagaiva, decimal poriva, bool dispoventa, bool regalo, bool combo, char bien, bool estado, decimal costou, decimal costop, decimal pvp, string principio_Activo, string laboratorio, string observacion, DateTime? fecha_Ingreso, string maquina, int usuario, string? nivel1_Nombre, string? nivel2_Nombre, string? nivel3_Nombre, string? nombremarca, string? nombre_Proveedor, string? nombre_Presentacion, string? cuenta, float? pvf, float porDes, string claseTerapeuta, string nombreClaseTerapeuta, bool controlLote, bool soloReceta, bool traContinuo, bool psicotropico, string? regSanitario, string? concentracion, string? formaFarmaceutica, string? presentacionFarmacion, float? stockPorBodega, double? precio, double? stockGeneral, float? stockMatriz)
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
            Fecha_Ingreso = fecha_Ingreso;
            Maquina = maquina;
            Usuario = usuario;
            Nivel1_Nombre = nivel1_Nombre;
            Nivel2_Nombre = nivel2_Nombre;
            Nivel3_Nombre = nivel3_Nombre;
            Nombremarca = nombremarca;
            Nombre_Proveedor = nombre_Proveedor;
            Nombre_Presentacion = nombre_Presentacion;
            Cuenta = cuenta;
            Pvf = pvf;
            PorDes = porDes;
            ClaseTerapeuta = claseTerapeuta;
            NombreClaseTerapeuta = nombreClaseTerapeuta;
            ControlLote = controlLote;
            SoloReceta = soloReceta;
            TraContinuo = traContinuo;
            Psicotropico = psicotropico;
            RegSanitario = regSanitario;
            Concentracion = concentracion;
            FormaFarmaceutica = formaFarmaceutica;
            PresentacionFarmacion = presentacionFarmacion;
            StockPorBodega = stockPorBodega;
            Precio = precio;
            StockGeneral = stockGeneral;
            StockMatriz = stockMatriz;
        }
    }
}
