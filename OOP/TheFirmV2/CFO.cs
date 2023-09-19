namespace TheFirmV2
{
    internal class CFO : CEO
    {
        /// <summary>
        /// The COO class is used for storing the repective cheif and instanciating the class itself
        /// </summary>
        internal CFO(string Name, string SurName, string CprNumber, bool HasCar) : base (Name, SurName, CprNumber, HasCar)
        {

        }

        internal uint CfoSalary { get; private set; }

        internal List<Chief> chief = new List<Chief>();
        public override string ToString()
        {
            return base.ToString();
        }

        internal override void RecieveSalary(uint salary)
        {
            CfoSalary = salary;
        }
    }
}
