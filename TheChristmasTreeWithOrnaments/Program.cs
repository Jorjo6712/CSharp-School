namespace TheChristmasTreeWithOrnaments
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < 8; i++)
            {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("*");

                if (i == 0 || i == 2 || i == 4 || i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                }

            }

            Console.ReadKey();
        }
    }
}
