
namespace MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente
{
    public class CreateClienteCommand : ClienteCommand
    {
        public CreateClienteCommand(string? codigo, string? codigo_cliente, int sucursal, string razon_social, string negocio, string representante
            , DateTime fecha_nacimiento, string tipodoc, string ruc, string direccion, string referencia, string celular, string telefono, int tipo_contribuyente
            , string correo, string provincia, string canton, string parroquia, string sector, string zona, string categoria, string tipo_cliente, string tipo_negocio
            , string medio_pago, string ruta_entrega, DateTime fecha_ingreso, DateTime fecha_ultimacompra, bool dvlu, bool dvma, bool dvmi, bool dvju, bool dvvi, bool dvsa
            , bool dvdo, string frecuencia, int orden, int vendedor, int vendedor_aux, int dias_credito, bool credito, float cupo, float extra_cupo, bool estado, string clavefe, string sexo
            , string estado_civil, string maquina, int usuario, bool relacionado, bool precioalcosto, float porcentajeincremento)
        {
            Codigo = codigo;
            Codigo_Cliente = codigo_cliente;
            Sucursal = sucursal;
            Razon_Social = razon_social;
            Negocio = negocio;
            Representante = representante;
            Fecha_Nacimiento = fecha_nacimiento;
            Tipodoc = tipodoc;
            Ruc = ruc;
            Direccion = direccion;
            Referencia = referencia;
            Celular = celular;
            Telefono = telefono;
            Tipo_Contribuyente = tipo_contribuyente;
            Correo = correo;
            Provincia = provincia;
            Canton = canton;
            Parroquia = parroquia;
            Sector = sector;
            Zona = zona;
            Categoria = categoria;
            Tipo_Cliente = tipo_cliente;
            Tipo_Negocio = tipo_negocio;
            Medio_Pago = medio_pago;
            Ruta_Entrega = ruta_entrega;
            Fecha_Ingreso = fecha_ingreso;
            Fecha_Ultimacompra = fecha_ultimacompra;
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
            Vendedor_Aux = vendedor_aux;
            Dias_Credito = dias_credito;
            Credito = credito;
            Cupo = cupo;
            Extra_Cupo = extra_cupo;
            Estado = estado;
            Clavefe = clavefe;
            Sexo = sexo;
            Estado_Civil = estado_civil;
            Maquina = maquina;
            Usuario = usuario;
            Relacionado = relacionado;
            PrecioAlCosto = precioalcosto;
            PorcentajeIncremento = porcentajeincremento;

        }
    }
}
