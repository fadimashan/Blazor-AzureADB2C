using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILayer.Shared.Models
{
    public class MachineResponse
    {
        public bool Success { get; set; }

        public List<string> ErrorMessages { get; set; }

        public List<Machine> Machine { get; set; }
    }
}
