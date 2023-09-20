namespace Reproduction_Station
{
    /// <summary>
    /// This is the dog class used for instantiating the dog animal and other purposes
    /// </summary>
    internal class Dog : Animal
    {
        protected private bool canBark;
        internal Dog(string Sex, string MammalType, byte Legs, bool HasFur, byte DepartAge, bool CanFly, bool CanBark) : base (Sex, MammalType, Legs, HasFur, DepartAge, CanFly)
        {
            canBark = CanBark;
        }

        internal override string Breed()
        {
            return "Dog is now breeding";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Can it bark: {canBark}";
        }
    }
}
