using System;
namespace Nim
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Welcome to NIM! \n");

            while (true)
            {
                try
                {
                    int matches = 7;

                    bool playerTurn;

                    bool gameOver;

                    Console.WriteLine("Your turn! Choose between 1-3 matches.");

                    int playerInput = Convert.ToInt32(Console.ReadLine());


                    if (matches == 0)
                    {
                        matches += 1;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fejl: " + ex.Message);
                }
            }
        }
    }
}
