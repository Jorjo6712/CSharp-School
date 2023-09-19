namespace TheFirm
{
    /// <summary>
    /// ProjectManager is used to inherit all base Employee superclass params and add onto it with it's own being phoneNumber
    /// </summary>
    internal class Manager : Employee
    {
        private protected int _phoneNumber;
        internal Manager(string Name, string SurName, string CprNumber, int PhoneNumber) : base(Name, SurName, CprNumber)
        {
            _phoneNumber = PhoneNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Phone: {_phoneNumber}";
        }
    }
}
