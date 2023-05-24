using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Commands.Inventario.Producto;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class ProductoServices : IProductoServices
    {
        private readonly IEventBus _eventBus;

        public ProductoServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(ProductoModel producto)
        {
            var createProductoCommand = new CreateProductoCommand(
                producto.Codigo,
                producto.Codigo_Producto,
                producto.Sucursal,
                producto.Codigo_Barra,
                producto.Codigo_Barra2,
                producto.Nombre,
                producto.Nombre_Extra,
                producto.Marca,
                producto.Presentacion,
                producto.Nivel1,
                producto.Nivel2,
                producto.Nivel3,
                producto.Proveedor,
                producto.Factor,
                producto.Pagaiva,
                producto.Poriva,
                producto.Dispoventa,
                producto.Regalo,
                producto.Combo,
                producto.Bien,
                producto.Estado,
                producto.Costou,
                producto.Costop,
                producto.Pvp,
                producto.Principio_Activo,
                producto.Laboratorio,
                producto.Observacion,
                producto.Fecha_Ingreso,
                producto.Maquina,
                producto.Usuario,
                producto.Nivel1_Nombre,
                producto.Nivel2_Nombre,
                producto.Nivel3_Nombre,
                producto.Nombremarca,
                producto.Nombre_Proveedor,
                producto.Nombre_Presentacion,
                producto.Cuenta,
                producto.Pvf,
                producto.PorDes,
                producto.ClaseTerapeuta,
                producto.NombreClaseTerapeuta,
                producto.ControlLote,
                producto.SoloReceta,
                producto.TraContinuo,
                producto.Psicotropico,
                producto.RegSanitario,
                producto.Concentracion,
                producto.FormaFarmaceutica,
                producto.PresentacionFarmacion,
                producto.StockPorBodega,
                producto.Precio,
                producto.StockGeneral,
                producto.StockMatriz,
                producto.TipoPeticion
                );
            _eventBus.SendCommand(createProductoCommand);
        }
    }
}
