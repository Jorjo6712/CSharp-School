namespace TheFirmV2
{
    /// <summary>
    /// The COO class is used for storing the repective cheif and instanciating the class itself
    /// </summary>
    internal class COO : CEO
    {
   
        internal COO(string Name, string SurName, string CprNumber, bool HasCar) : base (Name, SurName, CprNumber, HasCar)
        {

        }
        internal uint CooSalary { get; private set; }

        internal List<Chief> chief = new List<Chief>();
        public override string ToString()
        {
            return base.ToString();
        }

        internal override void RecieveSalary(uint salary)
        {
            CooSalary = salary;
        }
    }

}
