using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineB2C.Entities
{
    public class MachineResponse
    {
        public bool Success { get; set; }

        public List<string> ErrorMessages { get; set; }

        public List<MachineInfo> Machine { get; set; }
    }
}
