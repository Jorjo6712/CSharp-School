namespace TheFirmV2
{
    /// <summary>
    /// Superclass Employee which is used to give the base information that most other classes 
    /// inherit from to derive basic information about the employee.
    /// </summary>
    internal class Employee
    {
        private protected string _name;
        private protected string _surName;
        private protected string _cprNumber;

        internal Employee(string name, string surName, string cprNumber)
        {
            _name = name;
            _surName = surName;
            _cprNumber = cprNumber;
        }

        internal uint Salary { get; private set; }

        internal virtual void RecieveSalary(uint salary) 
        {
           Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Surname: {_surName}, CPR: {_cprNumber}";
        }
    }
}
