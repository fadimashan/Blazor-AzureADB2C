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


        [HttpPut]
        public async Task<ActionResult<MachineResponse>> Edit(int id)
        {

            var machine = await machineManager.GetMachine(id);

            if (machine is null)
            {
                return NotFound();
            }


            if (machine.Status == Status.Offline)
            {
                machine.Status = Status.Online;
                machine.Date = DateTime.Now;
            }
            else
            {
                machine.Status = Status.Offline;
                machine.Date = DateTime.MinValue;
            }

            if (await machineManager.SaveAsync())
            {
                return Ok(new OneMachineResponse()
                {
                    Success = true,
                    Machine = machine
                });
            }
            else
            {
                return StatusCode(500);
            }

        }

    }
}
