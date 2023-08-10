using System;
namespace StarsAndStripes
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < 12; i++) //
            {

                if (i == 0 || i == 10)
                {
                    Console.BackgroundColor = ConsoleColor.Blue; // changes color to blue
                    Console.Write("                         "); // then writes empty space

                    if (i == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("                     ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("                     ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write("   *   *   *   *   *   * ");
                        
                    }
                    else 
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("                     ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" *   *   *   *   *   *   ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("                     ");
                    }
                }

            }
        }
    }
}
