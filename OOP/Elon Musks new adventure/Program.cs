namespace ElonMusksNewAdventure
{
    internal class Program
    {   
        static RCCar redCar = new RCCar();
        static RCCar whiteCar = new RCCar();
        static void Main()
        {
            Controller();
        }

        #region Controller
        static void Controller()
        {
            RCCars();
            View();
        }
        #endregion 

        #region Methods
        static void RCCars()
        {
            redCar.Color = "Red";
            redCar.BatteryLife = 100;
            redCar.DistanceTraveled = 0;

            whiteCar.Color = "White";
            whiteCar.BatteryLife = 100;
            whiteCar.DistanceTraveled = 0;
        }

        #endregion 

        #region View
        static void View()
        {
            Console.WriteLine("Welcome to Elon Musk's RC-Car program!");
            Console.WriteLine("Choose your car: Red or White");
            
            while (true)
            {
                string inputDrive = Console.ReadLine();
                
                if (inputDrive == "Red" )
                {
                    DriveRed();
                }
                else if (inputDrive == "White")
                {
                    DriveWhite();
                }
                else
                {
                    break;
                }
            }
        }

        static void DriveRed()
        {
            Console.WriteLine($"Driving {redCar.Color}!");
            while (redCar.DistanceTraveled < 2000 && redCar.BatteryLife > 0)
            {
                redCar.Drive();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDisplay:");
                UpdateDisplay(redCar);
                Console.ResetColor();
            }

            if (redCar.BatteryLife <= 0)
            {
                ChargeMessage();
            }
        }

        static void DriveWhite()
        {
            Console.WriteLine($"Driving {whiteCar.Color}!");
            while (whiteCar.DistanceTraveled < 2000 && whiteCar.BatteryLife > 0)
            {
                whiteCar.Drive();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDisplay:");
                UpdateDisplay(whiteCar);
                Console.ResetColor();
            }

            if (whiteCar.BatteryLife <= 0)
            {
                ChargeMessage();
            }
        }

        static void ChargeMessage()
        {
            Console.WriteLine("\nBattery drained, please recharge!");
        }

        static void UpdateDisplay(RCCar car)
        {
            Console.WriteLine($"Car color: {car.Color}");
            Console.WriteLine($"Distance traveled: {car.DistanceTraveled} m");
            Console.WriteLine($"Battery Life: {car.BatteryLife}%");
        }

        #endregion 
    }
}