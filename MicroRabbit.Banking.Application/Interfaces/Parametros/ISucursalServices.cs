using MicroRabbit.Banking.Application.Models.Parametros;

namespace MicroRabbit.Banking.Application.Interfaces.Parametros
{
    public interface ISucursalServices
    {
        List<SucursalModel> Obtener();
    }
}
