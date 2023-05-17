namespace MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia
{
    public class CreateBancoCiaCommand : BancoCiaCommand
    {
        public CreateBancoCiaCommand(int codigo, string inicial_Banco, string cuenta, string nombre, string numero_Cuenta, string? nombre_cuenta, int ultimo_Cheque, string? tipo_Cuenta, int anio, bool contador_Automatico, string cuenta_Cheque_Fecha, string? nombre_cta_cheque, bool estado, DateTime? ultima_Conciliacion, DateTime? fecha_ing, DateTime? fechaRegistro, string? detalle, string? maquina, DateTime? fecha, int? usuario, int? sucursal)
        {
            Codigo = codigo;
            Inicial_Banco = inicial_Banco;
            Cuenta = cuenta;
            Nombre = nombre;
            Numero_Cuenta = numero_Cuenta;
            Nombre_cuenta = nombre_cuenta;
            Ultimo_Cheque = ultimo_Cheque;
            Tipo_Cuenta = tipo_Cuenta;
            Anio = anio;
            Contador_Automatico = contador_Automatico;
            Cuenta_Cheque_Fecha = cuenta_Cheque_Fecha;
            Nombre_cta_cheque = nombre_cta_cheque;
            Estado = estado;
            Ultima_Conciliacion = ultima_Conciliacion;
            Fecha_ing = fecha_ing;
            FechaRegistro = fechaRegistro;
            Detalle = detalle;
            Maquina = maquina;
            Fecha = fecha;
            Usuario = usuario;
            Sucursal = sucursal;
        }
    }
}
