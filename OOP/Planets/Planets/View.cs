namespace Planets
{
    /// <summary>
    /// This is where all GUI-related matters are handled in the program
    /// </summary>
    internal class View
    {
        // Used to write out all information regarding planet objects
        internal void PlanetInfo(string Name, float Mass, uint Diameter, ushort Density, float Gravity, float RotationPeriod, float DayLength, float SunDistance, float OrbitalPeriod, float OrbitalVelocity, short MeanTemperature, short NumOfMoons, string RingSystem)
        {
            Console.WriteLine($"\tPlanet name: {Name} ");
            Console.WriteLine($"\tPlanet mass(1024kg): {Mass} ");
            Console.WriteLine($"\tPlanet diameter(km): {Diameter}");
            Console.WriteLine($"\tPlanet density(kg/m3): {Density}");
            Console.WriteLine($"\tPlanet gravity(m/s2): {Gravity}");
            Console.WriteLine($"\tPlanet rotation period(hours): {RotationPeriod}");
            Console.WriteLine($"\tPlanet day length(hours): {DayLength}");
            Console.WriteLine($"\tPlanet distance from sun(106km): {SunDistance}");
            Console.WriteLine($"\tPlanet orbital period(days): {OrbitalPeriod}");
            Console.WriteLine($"\tPlanet orbital velocity(km/s): {OrbitalVelocity}");
            Console.WriteLine($"\tPlanet mean temperature(C): {MeanTemperature}");
            Console.WriteLine($"\tPlanet number of moons: {NumOfMoons}");
            Console.WriteLine($"\tPlanet ring system?: {RingSystem}");
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
