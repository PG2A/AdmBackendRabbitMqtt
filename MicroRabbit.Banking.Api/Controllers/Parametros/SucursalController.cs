
﻿using Microsoft.AspNetCore.Http;

﻿using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using Microsoft.AspNetCore.Cors;

using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Parametros
{

    [Route("api/sucursales")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

    [Route("api/sucursal")]
    [ApiController]
    public class SucursalController : ControllerBase
    {
        private readonly ISucursalServices _sucursalServices;

        public SucursalController(ISucursalServices sucursalServices)
        {
            _sucursalServices = sucursalServices;
        }
        [EnableCors]
        [HttpGet]
        public IActionResult Get()
        {
            _sucursalServices.Obtener();
            return Ok(200);
        }

    }
}
