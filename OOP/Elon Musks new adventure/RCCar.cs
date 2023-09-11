namespace ElonMusksNewAdventure
{
    internal class RCCar
    {
        private int _batteryLife;
        private int _distanceTraveled;

        private string _color = string.Empty;

        public (int BatteryLife, int DistanceTraveled) Display
        {
            get { return (_batteryLife, _distanceTraveled); }
            set { (_batteryLife, _distanceTraveled) = value; }
        }

        internal int BatteryLife
        {
            get {return _batteryLife;}
            set {_batteryLife = value;}
        }

        internal int DistanceTraveled
        {
            get {return _distanceTraveled;}
            set {_distanceTraveled = value;}
        }

        internal string Color
        {
            get {return _color;}
            set {_color = value;}
        }

        internal void Drive()
        {
            _distanceTraveled += 20;
            _batteryLife -= 1;
        }

        internal void Recharge()
        {
            _batteryLife = 100;
            _distanceTraveled = 0;
        }

    } 
}