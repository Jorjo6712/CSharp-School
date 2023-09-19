using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    internal class ProjectManager : Manager
    {
        private protected string _email;
        internal ProjectManager(string Name, string SurName, string CprNumber, int PhoneNumber, string Email) : base (Name,SurName,CprNumber, PhoneNumber)
        {
           _email = Email;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Email: {_email}";
        }
    }
}
