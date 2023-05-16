using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Commands.Inventario.Camion;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.Inventario
{
    public class CamionServices : ICamionServices
    {
        private readonly IEventBus _eventBus;

        public CamionServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Transfer(CamionModel camion)
        {
            var createCamionCommand = new CreateCamionCommand(camion.Codigo, camion.Nombre, camion.Placa, camion.Volumen, camion.Anio, camion.Peso, camion.Chofer, camion.Nombrechofer, camion.Nombresucursal, camion.Estado,
                camion.Detalle, camion.Fecha_Ingreso, camion.Maquina, camion.Usuario, camion.Sucursal);
            _eventBus.SendCommand(createCamionCommand);
        }
    }
}
