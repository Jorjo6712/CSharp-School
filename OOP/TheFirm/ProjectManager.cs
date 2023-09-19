namespace TheFirm
{
    /// <summary>
    /// ProjectManager is used to inherit all base Manager params and add onto it with it's own being email
    /// </summary>
    internal class ProjectManager : Manager
    {
        private protected string _email;
        internal ProjectManager(string Name, string SurName, string CprNumber, int PhoneNumber, string Email) : base (Name,SurName,CprNumber, PhoneNumber)
        {
           _email = Email;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Email: {_email}";
        }
    }
}
