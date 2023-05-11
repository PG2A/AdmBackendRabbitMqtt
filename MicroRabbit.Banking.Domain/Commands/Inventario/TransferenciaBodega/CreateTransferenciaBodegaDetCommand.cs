using MicroRabbit.Banking.Domain.Models.Inventario;
using System;

namespace MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega
{
    public class CreateTransferenciaBodegaDetCommand : TransferenciaBodegaDetCommand
    {
        public CreateTransferenciaBodegaDetCommand(string? codigo, int id_producto, int linea, string marca, int producto, float caja, float unidad, float totalfun, float factor, float? costoP, float? costoU, float precio, bool pagaiva, float poriva, float subtotal, float? pordes, float descuento, float iva, float neto, string? lote, DateTime? fechaela, DateTime? fechaven, string detalle, char formavta, float? cantdevo, float? cantconfirmada, float unidadestotales, int bodega, int bodegao)
        {
            Codigo = codigo;
            Id_producto = id_producto;
            Linea = linea;
            Marca = marca;
            Producto = producto;
            Caja = caja;
            Unidad = unidad;
            Totalfun = totalfun;
            Factor = factor;
            CostoP = costoP;
            CostoU = costoU;
            Precio = precio;
            Pagaiva = pagaiva;
            Poriva = poriva;
            Subtotal = subtotal;
            Pordes = pordes;
            Descuento = descuento;
            Iva = iva;
            Neto = neto;
            Lote = lote;
            Fechaela = fechaela;
            Fechaven = fechaven;
            Detalle = detalle;
            Formavta = formavta;
            Cantdevo = cantdevo;
            Cantconfirmada = cantconfirmada;
            Unidadestotales = unidadestotales;
            Bodega = bodega;
            Bodegao = bodegao;
        }
    }
}
