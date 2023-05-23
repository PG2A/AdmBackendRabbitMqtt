
namespace MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente
{
    public class CreateClienteCommand : ClienteCommand
    {
        public CreateClienteCommand(string? codigo, string? codigo_Cliente, int? sucursal, string? razon_Social, string? negocio, string? representante, DateTime? fecha_Nacimiento, string? tipodoc, string? ruc, string? direccion, string? referencia, string? celular, string? telefono, int? tipo_Contribuyente, string? correo, string? provincia, string? canton, string? parroquia, string? sector, string? zona, string? categoria, string? tipo_Cliente, string? tipo_Negocio, string? medio_Pago, string? ruta_Entrega, DateTime? fecha_Ingreso, DateTime? fecha_Ultimacompra, bool? dvlu, bool? dvma, bool? dvmi, bool? dvju, bool? dvvi, bool? dvsa, bool? dvdo, string? frecuencia, int? orden, int? vendedor, int? vendedor_Aux, int? dias_Credito, bool? credito, float? cupo, float? extra_Cupo, bool? estado, string? clavefe, string? sexo, string? estado_Civil, string? maquina, int? usuario, bool? relacionado, bool? precioAlCosto, float? porcentajeIncremento, string? tipopeticion)
        {
            Codigo = codigo;
            Codigo_Cliente = codigo_Cliente;
            Sucursal = sucursal;
            Razon_Social = razon_Social;
            Negocio = negocio;
            Representante = representante;
            Fecha_Nacimiento = fecha_Nacimiento;
            Tipodoc = tipodoc;
            Ruc = ruc;
            Direccion = direccion;
            Referencia = referencia;
            Celular = celular;
            Telefono = telefono;
            Tipo_Contribuyente = tipo_Contribuyente;
            Correo = correo;
            Provincia = provincia;
            Canton = canton;
            Parroquia = parroquia;
            Sector = sector;
            Zona = zona;
            Categoria = categoria;
            Tipo_Cliente = tipo_Cliente;
            Tipo_Negocio = tipo_Negocio;
            Medio_Pago = medio_Pago;
            Ruta_Entrega = ruta_Entrega;
            Fecha_Ingreso = fecha_Ingreso;
            Fecha_Ultimacompra = fecha_Ultimacompra;
            Dvlu = dvlu;
            Dvma = dvma;
            Dvmi = dvmi;
            Dvju = dvju;
            Dvvi = dvvi;
            Dvsa = dvsa;
            Dvdo = dvdo;
            Frecuencia = frecuencia;
            Orden = orden;
            Vendedor = vendedor;
            Vendedor_Aux = vendedor_Aux;
            Dias_Credito = dias_Credito;
            Credito = credito;
            Cupo = cupo;
            Extra_Cupo = extra_Cupo;
            Estado = estado;
            Clavefe = clavefe;
            Sexo = sexo;
            Estado_Civil = estado_Civil;
            Maquina = maquina;
            Usuario = usuario;
            Relacionado = relacionado;
            PrecioAlCosto = precioAlCosto;
            PorcentajeIncremento = porcentajeIncremento;
            TipoPeticion = tipopeticion;
        }
    }
}
