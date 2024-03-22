using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PrateekChadha
{
    public class Motorcycle : Vehicle
    {
        // Additional properties for Motorcycle
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }
    }
}
