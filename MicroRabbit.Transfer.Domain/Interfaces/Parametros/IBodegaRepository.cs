using MicroRabbit.Transfer.Domain.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Interfaces.Parametros
{
    public interface IBodegaRepository
    {
        List<BodegaTabla> ObtenerRegistros();
    }
}
