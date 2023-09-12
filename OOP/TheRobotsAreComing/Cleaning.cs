using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRobotsAreComingV1
{
    internal class Cleaning
    {
        private float _liquidSoapCapcity;
        Cleaning()
        {
            _liquidSoapCapcity = 2.3f; // liters
        }

        Cleaning(float liquidSoapCapcity) : this()
        {
            _liquidSoapCapcity = liquidSoapCapcity;
        }
    }
}
