using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Sweeper : Employee
    {
        internal Sweeper(string Name, string SurName, string CprNumber) : base (Name, SurName, CprNumber)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
