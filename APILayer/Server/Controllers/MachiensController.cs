using APILayer.Server.Data;
using APILayer.Server.Models;
using APILayer.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILayer.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MachiensController : ControllerBase
    {
        private IMachineManager machineManager;

        public MachiensController(IMachineManager _machineManager)
        {
            machineManager = _machineManager;

        }

        // GET: MachiensController
        [HttpGet]
        public async Task<ActionResult<MachineResponse>> Get()
        {
            var machines = await machineManager.GetAllMachines();
            return Ok( new MachineResponse()
            {
                Success = true,
                Machine = machines
            });
        }

    }
}
