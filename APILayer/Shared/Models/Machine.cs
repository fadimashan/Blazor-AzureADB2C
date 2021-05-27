using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILayer.Shared.Models
{
    public class Machine
    {
        
        public Guid GUID { get; set; }

        public string Name { get; set; }

        public Status Status { get; set; }

        public DateTime Date { get; set; }

        public string Icon { get; set; }
    
}
}
