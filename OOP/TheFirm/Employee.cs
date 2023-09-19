namespace TheFirm
{
    internal class Employee
    {
        private protected string _name = string.Empty;
        private protected string _surName = string.Empty;
        private protected string _cprNumber = string.Empty;
        internal Employee (string Name, string SurName, string CprNumber) 
        {
            _name = Name;
            _surName = SurName;
            _cprNumber = CprNumber;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Surname: {_surName}, CPR: {_cprNumber}";
        }
    }
}
