namespace Planets
{
    /// <summary>
    /// This is where all GUI related matters are handled in the program
    /// </summary>
    internal class View
    {
        // Used to write out all information regarding planet objets
        internal void PlanetInfo(string Name, float Mass, uint Diameter, ushort Density, float Gravity, float RotationPeriod, float DayLength, float SunDistance, float OrbitalPeriod, float OrbitalVelocity, short MeanTemperature, short NumOfMoons, string RingSystem)
        {
            Console.WriteLine($"\tPlanet name: {Name} ");
            Console.WriteLine($"\tPlanet mass: {Mass} ");
            Console.WriteLine($"\tPlanet diameter: {Diameter}");
            Console.WriteLine($"\tPlanet density: {Density}");
            Console.WriteLine($"\tPlanet gravity: {Gravity}");
            Console.WriteLine($"\tPlanet rotation period: {RotationPeriod}");
            Console.WriteLine($"\tPlanet day length: {DayLength}");
            Console.WriteLine($"\tPlanet distance from sun: {SunDistance}");
            Console.WriteLine($"\tPlanet orbital period: {OrbitalPeriod}");
            Console.WriteLine($"\tPlanet orbital velocity: {OrbitalVelocity}");
            Console.WriteLine($"\tPlanet mean temperature : {MeanTemperature}");
            Console.WriteLine($"\tPlanet number of moons: {NumOfMoons}");
            Console.WriteLine($"\tPlanet ring system: {RingSystem}");
            Console.WriteLine("\t----------------------------");
        }
        
        internal void NextTask() // Used for moving forward in the GUI helping display other task results
        {
            Console.WriteLine("\nPress enter to go to next task!");
            Console.ReadLine();
        }

        internal void CountElements(int count) // Used for Task 8
        {
            Console.WriteLine($"Elements count: {count}");
        }
    }
}
