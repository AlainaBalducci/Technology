using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public bool HasCamera { get; set; } = true;

        public SmartPhone(double ram, double screenSize, string operatingSystem) : base(ram, screenSize, operatingSystem)
        {
            
        }

        public void DropPhone()
        {
            HasCamera = false;
        }
    }
}
