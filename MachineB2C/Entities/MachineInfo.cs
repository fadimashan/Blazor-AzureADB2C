using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineB2C.Entities
{
    public class MachineInfo

    {
        public int Id { get; set; }
        public Guid GUID { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

        public DateTime Date { get; set; }

        public string Icon { get; set; } 
    }
}
