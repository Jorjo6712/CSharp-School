namespace TemperatureCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            
            Console.WriteLine("Temperature Calculator \n");

            Console.WriteLine("Write your celcius temperature: ");

            double celcius = double.Parse(Console.ReadLine()); // Reads celcius input

            double farenheit = celcius * 1.8 + 32; // Farenheit formula

            double reamur = celcius * 0.8; // Reaumur formula

            Console.WriteLine($"\nFarenheit: {farenheit}° \n");
            
            Console.WriteLine($"Reamur: {reamur}° \n");
            
            Console.WriteLine("Press any key to exit...");
            
            Console.ReadKey();
        }
    }
}
