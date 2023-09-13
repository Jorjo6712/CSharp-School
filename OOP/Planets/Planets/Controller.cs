namespace Planets
{
    internal class Controller
    {
        internal void Start() 
        {
            Planet planet = new Planet();

            for (int i = 0; i < 8; i++) 
            {
                planet.planets.Add(planet);
                planet.planets[i] = new Planet();
            }

            planet.planets[0].Name = "Mercury";
            planet.planets[0].Mass = 0.333f;
            planet.planets[0].Diameter = 4879;
            planet.planets[0].Density = 5427;
            planet.planets[0].Gravity = 3.7f;
            planet.planets[0].RotationPeriod = 1407.6f;
            planet.planets[0].DayLength = 4222.6f;
            planet.planets[0].SunDistance = 57.0f;
            planet.planets[0].OrbitalPeriod = 88.0f;
            planet.planets[0].OrbitalVelocity = 47.4f;
            planet.planets[0].MeanTemperature = 167;
            planet.planets[0].NumOfMoons = 0;
            planet.planets[0].RingSystem = "No";

            planet.planets[1].Name = "Venus";
            planet.planets[1].Mass = 4.87f;
            planet.planets[1].Diameter = 12104;
            planet.planets[1].Density = 5243;
            planet.planets[1].Gravity = 8.9f;
            planet.planets[1].RotationPeriod = -5832.5f;
            planet.planets[1].DayLength = 2802f;
            planet.planets[1].SunDistance = 108.2f;
            planet.planets[1].OrbitalPeriod = 224.7f;
            planet.planets[1].OrbitalVelocity = 35.0f;
            planet.planets[1].MeanTemperature = 464;
            planet.planets[1].NumOfMoons = 0;
            planet.planets[1].RingSystem = "No";

            planet.planets[2].Name = "Eearth";
            planet.planets[2].Mass = 5.97f;
            planet.planets[2].Diameter = 12756;
            planet.planets[2].Density = 5514;
            planet.planets[2].Gravity = 9.8f;
            planet.planets[2].RotationPeriod = 23.9f;
            planet.planets[2].DayLength = 24f;
            planet.planets[2].SunDistance = 149.6f;
            planet.planets[2].OrbitalPeriod = 365.2f;
            planet.planets[2].OrbitalVelocity = 29.8f;
            planet.planets[2].MeanTemperature = 15;
            planet.planets[2].NumOfMoons = 1;
            planet.planets[2].RingSystem = "No";

            planet.planets[3].Name = "Mars";
            planet.planets[3].Mass = 0.642f;
            planet.planets[3].Diameter = 6792;
            planet.planets[3].Density = 3933;
            planet.planets[3].Gravity = 3.7f;
            planet.planets[3].RotationPeriod = 24.6f;
            planet.planets[3].DayLength = 24.7f;
            planet.planets[3].SunDistance = 227.9f;
            planet.planets[3].OrbitalPeriod = 687.0f;
            planet.planets[3].OrbitalVelocity = 24.1f;
            planet.planets[3].MeanTemperature = -65;
            planet.planets[3].NumOfMoons = 2;
            planet.planets[3].RingSystem = "No";

            planet.planets[4].Name = "Jupiter";
            planet.planets[4].Mass = 1898f;
            planet.planets[4].Diameter = 142984;
            planet.planets[4].Density = 1326;
            planet.planets[4].Gravity = 23.1f;
            planet.planets[4].RotationPeriod = 9.9f;
            planet.planets[4].DayLength = 9.9f;
            planet.planets[4].SunDistance = 778.6f;
            planet.planets[4].OrbitalPeriod = 4331f;
            planet.planets[4].OrbitalVelocity = 13.1f;
            planet.planets[4].MeanTemperature = -110;
            planet.planets[4].NumOfMoons = 67;
            planet.planets[4].RingSystem = "Yes";

            planet.planets[5].Name = "Saturn";
            planet.planets[5].Mass = 568f;
            planet.planets[5].Diameter = 120536;
            planet.planets[5].Density = 687;
            planet.planets[5].Gravity = 9.0f;
            planet.planets[5].RotationPeriod = 10.7f;
            planet.planets[5].DayLength = 10.7f;
            planet.planets[5].SunDistance = 1433.5f;
            planet.planets[5].OrbitalPeriod = 10747f;
            planet.planets[5].OrbitalVelocity = 9.7f;
            planet.planets[5].MeanTemperature = -140;
            planet.planets[5].NumOfMoons = 62;
            planet.planets[5].RingSystem = "Yes";

            planet.planets[6].Name = "Saturn";
            planet.planets[6].Mass = 568f;
            planet.planets[6].Diameter = 120536;
            planet.planets[6].Density = 687;
            planet.planets[6].Gravity = 9.0f;
            planet.planets[6].RotationPeriod = 10.7f;
            planet.planets[6].DayLength = 10.7f;
            planet.planets[6].SunDistance = 1433.5f;
            planet.planets[6].OrbitalPeriod = 10747f;
            planet.planets[6].OrbitalVelocity = 9.7f;
            planet.planets[6].MeanTemperature = -140;
            planet.planets[6].NumOfMoons = 62;
            planet.planets[6].RingSystem = "Yes";


        }
    }
}
