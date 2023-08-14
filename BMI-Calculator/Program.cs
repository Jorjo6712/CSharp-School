namespace BMICalculator
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Clear();

                Console.WriteLine("[BMI Calculator]\n");

                Console.WriteLine("\nWrite your heigth in cm: \n");

                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nWrite your weight in kg: \n");

                double weight = Convert.ToDouble(Console.ReadLine());
                
                height /= 100;
                
                double bmi = weight / (height * height);

                bmi = Math.Floor(bmi * 10) / 10;

                if (bmi < 18.5)
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [body weight deficit]\n");
                }
                else if (bmi > 18.5 && bmi < 24)
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [norm]\n");
                }
                else if (bmi > 24 && bmi < 30)
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [weight over]\n");
                }
                else if (bmi > 30 && bmi < 35)
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [obesity first degree]\n");
                }
                else if (bmi > 35 && bmi < 40)
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [obesity second degree]\n");
                }
                else
                {
                    Console.WriteLine($"\nYour bmi is {bmi} and your weight class is [obesity third degree]\n");
                }
                
                Console.WriteLine("\nPress any key to exit...\n");
                
                Console.ReadKey();

                Console.Clear();
            }
            catch
            {
                Console.WriteLine("\nIncorrect format, use numbers only!\n");
            }
        }
    }
}
