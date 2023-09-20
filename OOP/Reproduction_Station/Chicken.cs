namespace Reproduction_Station
{
    /// <summary>
    /// This is the chicken class used for instantiating the chicken animal and other purposes
    /// </summary>
    internal class Chicken : Animal
    {
        protected private bool canGlide;
        internal Chicken(string Sex, string MammalType, byte Legs, bool HasFur, byte DepartAge, bool CanFly, bool CanGlide) : base (Sex, MammalType, Legs, HasFur, DepartAge, CanFly)
        {
            canGlide = CanGlide;
        }
        internal override string Breed() 
        { 
            return "Chicken is now breeding";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Can it glide: {canGlide}";
        }
    }
}
