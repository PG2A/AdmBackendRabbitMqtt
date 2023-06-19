using MicroRabbit.Transfer.Domain.Models.Inventario;
using MicroRabbit.Transfer.Domain.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface IProductoBodegaRepository
    {
        void Grabar(InvProductoBodegaTabla productobodega);
    }
}
