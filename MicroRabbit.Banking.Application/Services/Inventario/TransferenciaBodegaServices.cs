using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente;
using MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class TransferenciaBodegaServices : ITransferenciaBodegaServices
    {
        private readonly IEventBus _eventBus;

        public TransferenciaBodegaServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void EnviarCab(TransferenciaBodegaCabModel cabecera)
        {
            var createTransfBodCab = new CreateTransferenciaBodegaCabCommand(
            cabecera.Codigo, cabecera.Origen, cabecera.Sucursal, cabecera.SucursalD, cabecera.Tipo, cabecera.Tipoguia, cabecera.Serie, cabecera.Remision,
            cabecera.Numero, cabecera.Bodega, cabecera.Numpedido, cabecera.Numguia, cabecera.Cliente, cabecera.Fechaemi, cabecera.Fechaven, cabecera.Fechaent, cabecera.Bodegadestino, cabecera.Vendedor,
            cabecera.Proveedor, cabecera.Peso, cabecera.Volumen, cabecera.Motivo, cabecera.Observacion, cabecera.Comentario, cabecera.Seccontable, cabecera.Estado, cabecera.Estadodoc, cabecera.Enviadosri,
            cabecera.Numautorizacion, cabecera.Codigorel, cabecera.Fecha_ing, cabecera.Maquina, cabecera.Usuario, cabecera.DireccionOrigen, cabecera.Direcciondestino, cabecera.Camion, cabecera.Chofer);
            _eventBus.SendCommand(createTransfBodCab);
        }

        public void EnviarDet(TransferenciaBodegaDetModel detalle)
        {
            var createTransfBodDet = new CreateTransferenciaBodegaDetCommand(detalle.Codigo, detalle.Id_producto, detalle.Linea, detalle.Marca, detalle.Producto, detalle.Caja, detalle.Unidad, detalle.Totalfun,
                detalle.Factor, detalle.CostoP, detalle.CostoU, detalle.Precio, detalle.Pagaiva, detalle.Poriva, detalle.Subtotal, detalle.Pordes, detalle.Descuento, detalle.Iva,
                detalle.Neto, detalle.Lote, detalle.Fechaela, detalle.Fechaven, detalle.Detalle, detalle.Formavta, detalle.Cantdevo, detalle.Cantconfirmada, detalle.Unidadestotales, detalle.Bodega,
                detalle.Bodegao);
            _eventBus.SendCommand(createTransfBodDet);
        }
    }
}
