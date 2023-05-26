using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Banking.Data.Tablas
{
    public class SucursalTabla
    {
        [Key]
        public int Codigo { get; set; }
        public string Punto_emision { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Administrador { get; set; }
        public bool Estado { get; set; }
        public bool Esmatriz { get; set; }
        public int ContadorCliente { get; set; }
        public int ContadorProveedor { get; set; }
        public string InicialCliente { get; set; }
        public string Canton { get; set; }
        public string Eslogan { get; set; }
        public string NombreComercial { get; set; }
        public string UrlApi { get; set; }

    }
}
