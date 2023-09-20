namespace Reproduction_Station
{
    /// <summary>
    /// BookKeeping class used for keep track of newborn animals and existing adult animals
    /// </summary>
    internal class BookKeeping
    {
       internal List<Animal> animals = new List<Animal>();
       internal List<Rabbit> rabbits = new List<Rabbit>();
       internal List<Dog> dogs = new List<Dog>();
       internal List<Chicken> chickens = new List<Chicken>();
    }
}
