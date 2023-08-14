namespace LuckAndLotto
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to lotto!\n");

                Console.WriteLine("\nPress enter to begin and good luck!\n");

                ConsoleKeyInfo cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Enter)
                {
                    Random allNumbers = new Random();

                    int[] lotto = new int[8];

                    lotto[0] = allNumbers.Next(1, 36);
                    lotto[1] = allNumbers.Next(1, 36);
                    lotto[2] = allNumbers.Next(1, 36);
                    lotto[3] = allNumbers.Next(1, 36);
                    lotto[4] = allNumbers.Next(1, 36);
                    lotto[5] = allNumbers.Next(1, 36);
                    lotto[6] = allNumbers.Next(1, 36);
                    lotto[7] = allNumbers.Next(1, 36);

                    Array.Sort(lotto);

                    string num1 = $"\n{lotto[0]}";
                    string num2 = $"{lotto[1]}";
                    string num3 = $"{lotto[2]}";
                    string num4 = $"{lotto[3]}";
                    string num5 = $"{lotto[4]}";
                    string num6 = $"{lotto[5]}";
                    string num7 = $"{lotto[6]}";
                    string joker = $"{lotto[7]}\n";

                    foreach (int num in lotto)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write(num1 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num2 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num3 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num4 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num5 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num6 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num7 + ", ");

                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red;

                    Thread.Sleep(2000);

                    Console.Write(" " + joker);

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\nPress any key to exit...");

                    Console.ReadKey();

                    Console.Clear();

                    break;
                }
            }
        }
    }
}
