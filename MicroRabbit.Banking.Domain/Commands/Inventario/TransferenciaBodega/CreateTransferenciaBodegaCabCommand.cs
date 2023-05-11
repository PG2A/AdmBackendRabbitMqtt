using MicroRabbit.Banking.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega
{
    public class CreateTransferenciaBodegaCabCommand : TransferenciaBodegaCabCommand
    {
        public CreateTransferenciaBodegaCabCommand(string? codigo, string origen, int sucursal, int? sucursalD, string tipo, string tipoguia, string serie, bool remision, int numero, int bodega, int? numpedido, int? numguia, string? cliente, DateTime fechaemi, DateTime fechaven, DateTime? fechaent, int? bodegadestino, int? vendedor, int? proveedor, float? peso, float? volumen, string? motivo, string? observacion, string? comentario, string? seccontable, char estado, string? estadodoc, bool? enviadosri, string? numautorizacion, string? codigorel, DateTime fecha_ing, string maquina, int usuario, string direccionOrigen, string direcciondestino, int camion, int chofer)
        {
            Codigo = codigo;
            Origen = origen;
            Sucursal = sucursal;
            SucursalD = sucursalD;
            Tipo = tipo;
            Tipoguia = tipoguia;
            Serie = serie;
            Remision = remision;
            Numero = numero;
            Bodega = bodega;
            Numpedido = numpedido;
            Numguia = numguia;
            Cliente = cliente;
            Fechaemi = fechaemi;
            Fechaven = fechaven;
            Fechaent = fechaent;
            Bodegadestino = bodegadestino;
            Vendedor = vendedor;
            Proveedor = proveedor;
            Peso = peso;
            Volumen = volumen;
            Motivo = motivo;
            Observacion = observacion;
            Comentario = comentario;
            Seccontable = seccontable;
            Estado = estado;
            Estadodoc = estadodoc;
            Enviadosri = enviadosri;
            Numautorizacion = numautorizacion;
            Codigorel = codigorel;
            Fecha_ing = fecha_ing;
            Maquina = maquina;
            Usuario = usuario;
            DireccionOrigen = direccionOrigen;
            Direcciondestino = direcciondestino;
            Camion = camion;
            Chofer = chofer;
          //  Productos = productos;
        }
    }
}
