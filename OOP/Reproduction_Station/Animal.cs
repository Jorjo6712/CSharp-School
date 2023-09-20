namespace Reproduction_Station
{
    /// <summary>
    /// Superclass for all the animals where base information is defined
    /// </summary>
    internal abstract class Animal
    {
        private protected string sex;
        private protected string mammalType;
        private protected byte legs;
        private protected bool hasFur;
        private protected byte departAge;
        private protected bool canFly;

        private protected Animal(string Sex, string MammalType, byte Legs, bool HasFur, byte DepartAge, bool CanFly)
        {
            sex = Sex;
            mammalType = MammalType;
            legs = Legs;
            hasFur = HasFur;
            departAge = DepartAge;
            canFly = CanFly;
        }

        internal abstract string Breed();
        

        public virtual string ToString() 
        {
            return $"Animal sex: {sex}, Mammal type: {mammalType}, Amount of legs: {legs}, Does it have fur: {hasFur}, Retirement age: {departAge}, Can it fly: {canFly}";
        }


    }
}
