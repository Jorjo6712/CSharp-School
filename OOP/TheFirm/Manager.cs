using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class Manager : Employee
    {
        private protected int _phoneNumber;
        internal Manager(string Name, string SurName, string CprNumber, int PhoneNumber) : base(Name, SurName, CprNumber)
        {
            _phoneNumber = PhoneNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Phone: {_phoneNumber}";
        }
    }
}
