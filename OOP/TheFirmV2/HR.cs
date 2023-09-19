namespace TheFirmV2
{
    /// <summary>
    /// HR class used to instanciate employees who work in HR
    /// </summary>
    internal class HR : Employee
    {
        
        internal HR(string Name, string SurName, string CprNumber) : base (Name, SurName, CprNumber)
        {

        }

        internal uint Salary { get; private set; }

        public override string ToString()
        {
            return base.ToString();
        }

        internal void RecieveSalary(uint salary)
        {
            Salary += salary;
        }
    }
}
