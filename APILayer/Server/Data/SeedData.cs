using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILayer.Server.Data;
using APILayer.Server.Models;
using APILayer.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace APILayer.Server.Data
{
    public static class SeedData
    {

        public static async Task InitAsync(IServiceProvider services)
        {
            using (var context = new ApiDbContext(services.GetRequiredService<DbContextOptions<ApiDbContext>>()))
            {
                if (context.Machine.Any())
                {
                    return;
                }
                else
                {
                  
                    context.AddRange(GetMachines());
                    await context.SaveChangesAsync();
                }
            }
        }

        private static List<Machine> GetMachines()
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

            return machines;
        }

    }   
}
