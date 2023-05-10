using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events.CuentasPorCobrar
{
    public class ClienteCreateEvent : Event
    {
        public string? Codigo { get; set; }
        public string? Codigo_Cliente { get; set; }
        public int Sucursal { get; set; }
        public string Razon_Social { get; set; }
        public string Negocio { get; set; }
        public string Representante { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Tipodoc { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public int Tipo_Contribuyente { get; set; }
        public string Correo { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Parroquia { get; set; }
        public string Sector { get; set; }
        public string Zona { get; set; }
        public string Categoria { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Tipo_Negocio { get; set; }
        public string Medio_Pago { get; set; }
        public string Ruta_Entrega { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Ultimacompra { get; set; }
        public bool Dvlu { get; set; }
        public bool Dvma { get; set; }
        public bool Dvmi { get; set; }
        public bool Dvju { get; set; }
        public bool Dvvi { get; set; }
        public bool Dvsa { get; set; }
        public bool Dvdo { get; set; }
        public string Frecuencia { get; set; }
        public int Orden { get; set; }
        public int Vendedor { get; set; }
        public int Vendedor_Aux { get; set; }
        public int Dias_Credito { get; set; }
        public bool Credito { get; set; }
        public float Cupo { get; set; }
        public float Extra_Cupo { get; set; }
        public bool Estado { get; set; }
        public string Clavefe { get; set; }
        public string Sexo { get; set; }
        public string Estado_Civil { get; set; }
        public string Maquina { get; set; }
        public int Usuario { get; set; }
        public bool Relacionado { get; set; }
        public bool? PrecioAlCosto { get; set; }
        public float? PorcentajeIncremento { get; set; }

        public ClienteCreateEvent(string? codigo, string? codigo_Cliente, int sucursal, string razon_Social, string negocio, string representante, DateTime fecha_Nacimiento, string tipodoc, string ruc, string direccion, string referencia, string celular, string telefono, int tipo_Contribuyente, string correo, string provincia, string canton, string parroquia, string sector, string zona, string categoria, string tipo_Cliente, string tipo_Negocio, string medio_Pago, string ruta_Entrega, DateTime fecha_Ingreso, DateTime fecha_Ultimacompra, bool dvlu, bool dvma, bool dvmi, bool dvju, bool dvvi, bool dvsa, bool dvdo, string frecuencia, int orden, int vendedor, int vendedor_Aux, int dias_Credito, bool credito, float cupo, float extra_Cupo, bool estado, string clavefe, string sexo, string estado_Civil, string maquina, int usuario, bool relacionado, bool? precioAlCosto, float? porcentajeIncremento)
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
        }
    }
}
