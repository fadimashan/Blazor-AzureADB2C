using APILayer.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILayer.Server.Data
{
    public class LocalMachineManager : IMachineManager
    {
        public async Task<List<Machine>> GetAllMachines()
        {
            List<Machine> machines = new List<Machine>() { 
            
                new Machine
                {
                    Name = "M233",
                    Status = 0,
                    Date = DateTime.Parse("08/18/2018 07:22:16"),
                    GUID = Guid.NewGuid()
                },
                 new Machine
                {
                    Name = "M234",
                    Status = 0,
                    Date = DateTime.Parse("02/18/2012 09:22:16"),
                    GUID = Guid.NewGuid()
                },
                  new Machine
                {
                    Name = "M2S3",
                    Status = 0,
                    Date = DateTime.Parse("01/11/2021 07:22:16"),
                    GUID = Guid.NewGuid()
                },
                   new Machine
                {
                    Name = "M2783",
                    Status = 0,
                    Date = DateTime.Parse("04/08/2020 07:22:16"),
                    GUID = Guid.NewGuid()
                }

            };

            await Task.Delay(1);

            return  machines;
        }
    }
}


