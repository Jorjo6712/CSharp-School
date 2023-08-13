namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BMI Calculator");

            Console.WriteLine("Write your heigth: ");

            double? height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write your weight: ");

            double? weight = Convert.ToDouble(Console.ReadLine());


        }
    }
}
