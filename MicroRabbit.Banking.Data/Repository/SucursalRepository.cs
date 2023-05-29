using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models.Parametros;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Repository
{
    public class SucursalRepository : ISucursalRepository
    {

        private readonly TablasContext _tablas;

        public SucursalRepository(TablasContext tablas)
        {
            _tablas = tablas;
        }

        public List<SucursalModel> Listar()
        {
            var lista = new List<SucursalModel>();
            var lista2 = _tablas.ObtenerTodasLasSucursales();
            foreach (var item in lista2)
            {
                var nuevaLista = new SucursalModel
                {
                    Codigo = item.Codigo,
                    Punto_emision = item.Punto_emision,
                    Nombre= item.Nombre,
                    Direccion= item.Direccion,
                    Celular= item.Celular,
                    Correo= item.Correo,
                    Administrador= item.Administrador,
                    Estado= item.Estado,
                    Esmatriz= item.Esmatriz,
                    ContadorCliente = item.ContadorCliente,
                    ContadorProveedor= item.ContadorProveedor,
                    InicialCliente= item.InicialCliente,
                    Canton= item.Canton,
                    Eslogan = item.Eslogan, 
                    NombreComercial= item.NombreComercial,
                    UrlApi= item.UrlApi,
                };
                lista.Add(nuevaLista);
            }
            
            return lista;
        }
    }
}
