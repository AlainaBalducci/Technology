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

        public SmartPhone(bool hasCamera, double ram, double screenSize, string operatingSystem) : base(ram, screenSize, operatingSystem)
        {
            HasCamera = hasCamera;
        }

        public void DropPhone()
        {
            HasCamera = false;
        }
    }
}
