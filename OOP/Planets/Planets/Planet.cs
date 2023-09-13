using System.Runtime.CompilerServices;

namespace Planets
{
    internal class Planet
    {

        internal List <Planet> planets = new List <Planet> ();

        private string _name;
        private float _mass;
        private uint _diameter;
        private ushort _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _dayLength;
        private float _sunDistance;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private short _meanTemperature;
        private short _numOfMoons;
        private string _ringSystem;

        internal string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        internal float Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        internal uint Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
        internal ushort Density 
        {
            get { return _density; }
            set { _density = value; }
        }

        internal float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }

        internal float RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }

        internal float DayLength
        {
            get { return _dayLength; }
            set { _dayLength = value; }
        }

        internal float SunDistance
        {
            get { return _sunDistance; }
            set { _sunDistance = value; }
        }

        internal float OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            set { _orbitalPeriod = value;}
        }

        internal float OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            set { _orbitalVelocity = value;}
        }
        
        internal short MeanTemperature
        {
            get { return _meanTemperature; }
            set { _meanTemperature = value; }
        }

        internal short NumOfMoons
        {
            get { return _numOfMoons; }
            set { _numOfMoons = value; }
        }

        internal string RingSystem
        {
            get { return _ringSystem; }
            set { _ringSystem = value; }
        }

    }
}
