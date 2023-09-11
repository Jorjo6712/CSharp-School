namespace ElonMusksNewAdventure
{
    internal class RCCar
    {
        private int _batteryLife;
        private int _distanceTraveled;

        private string _color = string.Empty;

        internal int BatteryLife
        {
            get {return _batteryLife;}
            set {_batteryLife = value;}
        }

    } 
}