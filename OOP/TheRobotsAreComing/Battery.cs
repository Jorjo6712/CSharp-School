using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRobotsAreComingV1
{
    internal class Battery
    {
        private byte _batteryCapacity;

        private Battery() 
        {
        }

        internal Battery(byte BatteryCapacity) : this()
        {
            _batteryCapacity = BatteryCapacity;
        }    
        
    }
}
