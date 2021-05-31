using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILayer.Server.Models
{
    public class OneMachineResponse
    {
        public bool Success { get; set; }

        public List<string> ErrorMessages { get; set; }

        public Machine Machine { get; set; }
    }
}
