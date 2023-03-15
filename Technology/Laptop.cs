using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Laptop : Computer
    {
        public int NumOfUsb { get; set; }

        public Laptop(double ram, double screenSize, string operatingSystem) : base(ram, screenSize, operatingSystem)
        {

        }
    }

    
}
