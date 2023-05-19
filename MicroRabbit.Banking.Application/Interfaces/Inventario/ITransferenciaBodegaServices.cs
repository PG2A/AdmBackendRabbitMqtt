using MicroRabbit.Banking.Application.Models.Inventario;

namespace MicroRabbit.Banking.Application.Interfaces.Inventario
{
    public interface ITransferenciaBodegaServices
    {
        void EnviarCab(TransferenciaBodegaCabModel cabecera); 
        void EnviarDet(TransferenciaBodegaDetModel detalle);
    }
}
