using MicroRabbit.Banking.Domain.Models.Inventario;


namespace MicroRabbit.Banking.Domain.Commands.Inventario.AjusteIngreso
{
    public class CreateAjusteIngresoCommand : AjusteIngresoCommand
    {
        public CreateAjusteIngresoCommand(string codigo, int sucursal, string tipo, string? serie, int? numero, int bodega, string? cliente, DateTime fechaemi, DateTime? fechaent, int? bodegaorigen, int? vendedor, int proveedor, float? peso, float? volumen, string? motivo, string? observacion, string? comentario, string seccontable, string? estado, string? estadodoc, int? enviadosri, int? numautorizacion, string? codigorel, DateTime? fecha_ing, string? maquina, int usuario, string? claseAjuste, List<AjusteIngresoDetModel>? productos)
        {
            Codigo = codigo;
            Sucursal = sucursal;
            Tipo = tipo;
            Serie = serie;
            Numero = numero;
            Bodega = bodega;
            Cliente = cliente;
            Fechaemi = fechaemi;
            Fechaent = fechaent;
            Bodegaorigen = bodegaorigen;
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
            ClaseAjuste = claseAjuste;
            Productos = productos;
        }
    }
}
