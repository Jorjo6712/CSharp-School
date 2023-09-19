namespace TheFirmV2
{
    /// <summary>
    /// Chief class used for storing leaders that work under each Chief and used for instanciating the Chiefs themselves
    /// </summary>
    internal class Chief : Employee
    {
        internal Chief(string Name, string SurName, string CprNumber) : base(Name, SurName, CprNumber) 
        { 
        
        }
        internal uint ChiefSalary { get; private set; }

        internal List<Leader> leaders = new List<Leader>();
        public override string ToString()
        {
            return base.ToString();
        }
        
        internal override void RecieveSalary(uint salary)
        {
            ChiefSalary = salary;
        }
    }

}
