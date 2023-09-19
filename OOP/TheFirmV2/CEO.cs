namespace TheFirmV2
{
    /// <summary>
    /// The CEO class is the clas which is the class that CFO and COO inherit from it being the highest in the hirearchy,
    /// it's also used for storing both HR and Administration employees
    /// </summary>
    internal class CEO : Employee
    {
        private protected bool _canFire;
        private protected bool _hasCar;
        private protected uint _ceoSalary;
        internal CEO(string Name, string SurName, string CprNumber, bool HasCar) : base (Name,SurName,CprNumber)
        {
            _hasCar = HasCar;
        }

        internal uint CeoSalary { get; private set; }

        internal List<HR> hRs = new List<HR>();
        internal List<Administration> admins = new List<Administration>();

        public override string ToString()
        {
            return $"{base.ToString()}, Has Car: {_hasCar}";
        }

        internal override void RecieveSalary(uint salary)
        {
            CeoSalary = salary;
        }
    }
}
