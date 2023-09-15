using System.Xml.Linq;

namespace Planets
{
    /// <summary>
    /// This is the controller class file where the logic is controlled between the GUI (View) and Model(Planet)
    /// </summary>
    internal class Controller
    {
        Planet planet = new Planet(); // Instanciating objects
        View view = new View();
        internal void MainController() // MainController calls all Task methods
        {
            TaskThree();
            TaskFour();
            TaskFive();
            TaskSix();
            TaskSeven();
            TaskEight();
            TaskNine();
            TaskTen();
            TaskEleven();
        }

        private List<Planet> planets = new List<Planet>() // Create planets list and fill it with objects with different properties
        {
            new Planet()
            {
                Name = "Mercury", Mass = 0.333f, Diameter = 4879,
                Density = 5427, Gravity = 3.7f, RotationPeriod = 1407.6f,
                DayLength = 4222.6f, SunDistance = 57.0f, OrbitalPeriod = 88.0f,
                OrbitalVelocity = 47.4f, MeanTemperature = 167, NumOfMoons = 0,
                RingSystem = "No"
            }

            ,

            new Planet()
            {
                Name = "Earth", Mass = 5.97f, Diameter = 12756, Density = 5514,
                Gravity = 9.8f, RotationPeriod = 23.9f, DayLength = 24f, SunDistance = 149.6f,
                OrbitalPeriod = 365.2f, OrbitalVelocity = 29.8f, MeanTemperature = 15,
                NumOfMoons = 1, RingSystem = "No"
            }

            ,

            new Planet()
            {
                Name = "Mars", Mass = 0.642f, Diameter = 6792, Density = 3933,
                Gravity = 3.7f, RotationPeriod = 24.6f, DayLength = 24.7f,
                SunDistance = 227.9f, OrbitalPeriod = 687.0f, OrbitalVelocity = 24.1f,
                MeanTemperature = -65, NumOfMoons = 2, RingSystem = "No"
            }

            ,

            new Planet()
            {
                Name = "Jupiter", Mass = 1898f, Diameter = 142984, Density = 1326,
                Gravity = 23.1f, RotationPeriod = 9.9f, DayLength = 9.9f,
                SunDistance = 778.6f, OrbitalPeriod = 4331f, OrbitalVelocity = 13.1f,
                MeanTemperature = -110, NumOfMoons = 67, RingSystem = "Yes"
            }

            ,

            new Planet()
            {
                Name = "Saturn", Mass = 568f, Diameter = 120536, Density = 687,
                Gravity = 9.0f, RotationPeriod = 10.7f, DayLength = 10.7f,
                SunDistance = 1433.5f, OrbitalPeriod = 10747f, OrbitalVelocity = 9.7f,
                MeanTemperature = -140, NumOfMoons = 62, RingSystem = "Yes"
            }

            ,

            new Planet()
            {
                Name = "Uranus", Mass = 86.8f, Diameter = 51118, Density = 1271,
                Gravity = 8.7f, RotationPeriod = -17.2f, DayLength = 17.2f,
                SunDistance = 2872.5f, OrbitalPeriod = 30589f, OrbitalVelocity = 6.8f,
                MeanTemperature = -195, NumOfMoons = 27, RingSystem = "Yes"
            }

            ,

            new Planet()
            {
                Name = "Neptune", Mass = 102f, Diameter = 49528, Density = 1638,
                Gravity = 11.0f, RotationPeriod = 16.1f, DayLength = 16.1f,
                SunDistance = 4495.1f, OrbitalPeriod = 59.8f, OrbitalVelocity = 5.4f,
                MeanTemperature = -200, NumOfMoons = 14, RingSystem = "Yes"
            }

            ,

            new Planet()
            {
                Name = "Pluto", Mass = 0.0146f, Diameter = 2370, Density = 2095,
                Gravity = 0.7f, RotationPeriod = -153.3f, DayLength = 153.3f,
                SunDistance = 5906.4f, OrbitalPeriod = 90.56f, OrbitalVelocity = 4.7f,
                MeanTemperature = -225, NumOfMoons = 5, RingSystem = "No"
            }
        };

        internal void TaskThree() // Displays all planets
        {
            foreach (var planet in planets)
            {
                view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
            }

            view.NextTask();
        }

        internal void TaskFour() // Adds Venus to list
        {
            planets.Insert(1, planet);
            planets[1] = planet;

            planets[1].Name = "Venus";
            planets[1].Mass = 4.87f;
            planets[1].Diameter = 12104;
            planets[1].Density = 5243;
            planets[1].Gravity = 8.9f;
            planets[1].RotationPeriod = -5832.5f;
            planets[1].DayLength = 2802f;
            planets[1].SunDistance = 108.2f;
            planets[1].OrbitalPeriod = 224.7f;
            planets[1].OrbitalVelocity = 35.0f;
            planets[1].MeanTemperature = 364;
            planets[1].NumOfMoons = 0;
            planets[1].RingSystem = "No";

            view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);

            view.NextTask();
        }

        internal void TaskFive() // Displays all planets to check if Venus is added
        {
            foreach (var planet in planets)
            {
                view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
            }
            view.NextTask();
        }

        internal void TaskSix() // Removes Pluto from the planets list
        {
            for (int i = 0; i < planets.Count; i++) 
            {
               if (planets[i].Name == "Pluto") 
                {
                    planets.Remove(planets[i]);
                }
            }

            foreach (var planet in planets)
            {
                view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
            }

            view.NextTask();
        }

        internal void TaskSeven() // Adds Pluto back to list
        {
            planets.Add(planet);
            Planet pluto = planets.Last();

            pluto.Name = "Pluto";
            pluto.Mass = 0.0146f;
            pluto.Diameter = 2370;
            pluto.Density = 2095;
            pluto.Gravity = 0.7f;
            pluto.RotationPeriod = -153.3f;
            pluto.DayLength = 153.3f;
            pluto.SunDistance = 5906.4f;
            pluto.OrbitalPeriod = 90.56f;
            pluto.OrbitalVelocity = 4.7f;
            pluto.MeanTemperature = -225;
            pluto.NumOfMoons = 5;
            pluto.RingSystem = "No";

            foreach (var planet in planets)
            {
                view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
            }

            view.NextTask();

        }

        internal void TaskEight() // Counts all elements and displays amount
        {
            view.CountElements(planets.Count());
            view.NextTask();
        }

        internal void TaskNine() // Creates a new list which displays only planets who's mean temperatures are under 0
        {
            List<Planet> lowerMeanTemperatures = new List<Planet>();

            foreach (Planet planet in planets)
            {
                if (planet.MeanTemperature < 0)
                {
                    lowerMeanTemperatures.Add(planet);
                    view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
                }
            }
            view.NextTask();

        }

        internal void TaskTen() // Creates a new list which displays only planets who are over 10000 km in diameter and under 50000 km in diameter.
        {
            List<Planet> diameter = new List<Planet>();

            foreach (Planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    diameter.Add(planet);
                    view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);
                }
            }
            view.NextTask();
        }

        internal void TaskEleven() // Clears planets list
        {
            planets.Clear();

            view.PlanetInfo(planet.Name, planet.Mass, planet.Diameter, planet.Density, planet.Gravity, planet.RotationPeriod, planet.DayLength, planet.SunDistance, planet.OrbitalPeriod, planet.OrbitalVelocity, planet.MeanTemperature, planet.NumOfMoons, planet.RingSystem);

            view.NextTask();
        }
    }
}
