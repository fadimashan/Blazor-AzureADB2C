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

        public async Task<Machine> GetMachine(int id)
        {
            var machine = await db.Machine.FindAsync(id);
            return machine;
        }

        public async Task<bool> SaveAsync()
        {
            return (await db.SaveChangesAsync()) >= 0;
        }
    }
}


