using APILayer.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILayer.Shared.Models
{
    public interface IMachineManager
    {
        Task<List<Machine>> GetAllMachines();
    }
}
