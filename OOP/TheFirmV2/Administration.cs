namespace TheFirmV2
{
    /// <summary>
    /// Administration class used to instanciate employees who work in Administration
    /// </summary>
    internal class Administration : Employee
    {
        internal Administration (string Name, string SurName, string CprNumber) : base (Name, SurName, CprNumber)
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
