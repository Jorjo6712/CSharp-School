namespace kontrolstrukturtest
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Press the enter key to roll dice!\n");

                ConsoleKeyInfo cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Enter)
                {
                    Random random = new Random();

                    int dice = random.Next(1, 7);

                    Console.Clear();

                    Console.WriteLine($"You rolled a {dice}\n");
                }
                else if (cki.Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
