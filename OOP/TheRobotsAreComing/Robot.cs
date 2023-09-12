using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheRobotsAreComingV1;

namespace TheRobotsAreComing
{
    internal class Robot
    {
        /// <summary>
        /// This assignment is about a robot factory with robots where each have their own ability to do something productive.
        /// There are 3 kinds of robots, 1 being no chip, 2 being those with a RX chip and 3 being the ones with QT chip.
        /// The ones which have no chip are small robots. They clean the floors.
        /// The ones with a RX chip are capable of cleaning both windows and the floors.
        /// There are also colors scheemes that the robots are produced in, the default being white, howver with a
        /// condition being that a robot who comes with a non-default scheme comes with no battery.
        /// A few robots have Wi-Fi, which can be any robot of any type but not all.
        /// The robots which are on window cleaning duty carry a liquid soap resirvoir which has a capacity of 2.3 liters.
        /// Robots with no chip can not have wheels.
        /// </summary>
        
        private string _chip = string.Empty;
        
        private Color _color;

        private bool _hasWiFi;

        private bool _hasBattery;

        private short _wheels;

        private byte _batteryCapacity;

        internal Robot() 
        {
            _chip = "default";
            _color = Color.White;
            _hasWiFi = false;
            _hasBattery = true;
            _wheels = 0;
            _batteryCapacity = 0;
        }

        internal Robot(bool WiFi) : this()
        { 
            _hasWiFi = WiFi;
        }

        internal Robot(Color color) : this()
        {
            _color = color;
        }

        internal Robot(string chip) : this()
        {
            _chip = chip;
        }

        internal Robot(short wheels, string chip) : this (chip)
        {
            _wheels = wheels;
        }

        internal Robot (Color color, bool hasBattery) : this(color) 
        {
            _hasBattery = hasBattery;
        }
    }
}
