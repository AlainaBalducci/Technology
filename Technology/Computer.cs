using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public double Ram { get; set; }
        public readonly double ScreenSize;
        public string OperatingSystem { get; set; }


        public Computer(double ram, double screenSize, string operatingSystem) : base()
        {
            Ram = ram;
            ScreenSize = screenSize;
            OperatingSystem = operatingSystem;
            
        }

        public void PrintStats()
        {
            Console.WriteLine($"Screen Size: {ScreenSize}{Environment.NewLine}Operating system: {OperatingSystem}{Environment.NewLine}Memory Space: {Ram}");
        }

        public void UpgradeRam(double uRam)
        {
           Ram += uRam;

            
        }
    }
}
