namespace TheFirm
{
    /// <summary>
    /// This is the Sweeper class which is based on the Employee superclass
    /// and is no different than it but is still used to create a different type of employee
    /// </summary>
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
