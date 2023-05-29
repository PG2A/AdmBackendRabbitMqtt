﻿using MediatR;
using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Models.CuentasPorCobrar;
using MicroRabbit.Banking.Domain.Commands.CuentasPorCobrar.Cliente;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.CuentasPorCobrar
{
    public class ClienteServices : IClienteServices
    {
        private readonly IEventBus _eventBus;

        private ISucursalRepository _sucursalRepository; 
        public ClienteServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public ClienteServices(IEventBus eventBus, ISucursalRepository sucursalRepository)
        {
            _eventBus = eventBus;
            _sucursalRepository = sucursalRepository;
        }

        public void Enviar(ClienteModel cliente)
        {
            var todas = _sucursalRepository == null ? 0 : _sucursalRepository.Listar().Count();
            var createCLienteCommand =  new CreateClienteCommand(
            cliente.Codigo, 
            cliente.Codigo_Cliente,
            cliente.Sucursal, 
            cliente.Razon_Social,
            cliente.Negocio,
            cliente.Representante,
            cliente.Fecha_Nacimiento,
            cliente.Tipodoc, 
            cliente.Ruc, 
            cliente.Direccion,
            cliente.Referencia,
            cliente.Celular,
            cliente.Telefono,
            cliente.Tipo_Contribuyente,
            cliente.Correo, 
            cliente.Provincia,
            cliente.Canton,
            cliente.Parroquia,
            cliente.Sector,
            cliente.Zona,
            cliente.Categoria,
            cliente.Tipo_Cliente, 
            cliente.Tipo_Negocio,
            cliente.Medio_Pago,
            cliente.Ruta_Entrega,
            cliente.Fecha_Ingreso,
            cliente.Fecha_Ultimacompra,
            cliente.Dvlu,
            cliente.Dvma,
            cliente.Dvmi,
            cliente.Dvju,
            cliente.Dvvi,
            cliente.Dvsa,
            cliente.Dvdo,
            cliente.Frecuencia,
            cliente.Orden,
            cliente.Vendedor,
            cliente.Vendedor_Aux,
            cliente.Dias_Credito,
            cliente.Credito,
            cliente.Cupo, 
            cliente.Extra_Cupo,
            cliente.Estado, 
            cliente.Clavefe,
            cliente.Sexo,
            cliente.Estado_Civil,
            cliente.Maquina,
            cliente.Usuario,
            cliente.Relacionado,
            cliente.PrecioAlCosto,
            cliente.PorcentajeIncremento,
            cliente.TipoPeticion,
            todasSucursales:todas
            );
            _eventBus.SendCommand(createCLienteCommand);
        }
    }
}
