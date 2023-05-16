using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface ICamionRepository
    {
        void Grabar(CamionTabla camion);
    }
}
