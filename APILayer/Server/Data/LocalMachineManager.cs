using APILayer.Server.Models;
using APILayer.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILayer.Server.Data
{
    public class LocalMachineManager : IMachineManager
    {
        private readonly ApiDbContext db;

        public LocalMachineManager(ApiDbContext _db)
        {
            db = _db;
        }
        public async Task<List<Machine>> GetAllMachines()
        {
            var machines = await db.Machine.ToListAsync();

            return machines;
        }
    }
}


