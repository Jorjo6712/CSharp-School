namespace TheFirmV2
{
    /// <summary>
    /// Leader class used for storing employees that work under each leader and used for instanciating the leaders themselves
    /// </summary>
    internal class Leader : Employee
    {
        internal Leader(string Name, string Surname, string CprNumber) : base (Name, Surname, CprNumber)
        {

        }

        internal uint LeaderSalary { get; private set; }

        internal List<Employee> employees = new List<Employee>();

        public override string ToString()
        {
            return base.ToString();
        }

        internal override void RecieveSalary(uint salary)
        {
            LeaderSalary = salary;
        }
    }
}
