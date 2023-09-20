namespace Reproduction_Station
{
    /// <summary>
    /// This is the rabbit class used for instantiating the rabbit animal and other purposes
    /// </summary>
    internal class Rabbit : Animal
    {
        protected private bool jumpFast;

        internal Rabbit(string Sex, string MammalType, byte Legs, bool HasFur, byte DepartAge, bool CanFly, bool JumpFast) : base(Sex, MammalType, Legs, HasFur, DepartAge,CanFly)
        {
            jumpFast = JumpFast;
        }

        internal override string Breed()
        {
            return "Rabbit is now breeding";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Can it jump fast: {jumpFast}";
        }
    }
}
