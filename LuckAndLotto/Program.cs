namespace LuckAndLotto
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear(); // Clears the console so that it's easier to focus on the program and removes any other previous text

                Console.WriteLine("Welcome to lotto!\n");

                Console.WriteLine("\nPress enter to begin and good luck!\n");

                ConsoleKeyInfo cki = Console.ReadKey(); // Reads in key

                if (cki.Key == ConsoleKey.Enter) // Checks if 'Enter' is pressed if not just defaults to continuing the loop
                {
                    Random allNumbers = new Random(); // Initializes Random constructor

                    int[] lotto = new int[8]; // Initializes an integer array with 8 numbers

                    lotto[0] = allNumbers.Next(1, 36);
                    lotto[1] = allNumbers.Next(1, 36);  
                    lotto[2] = allNumbers.Next(1, 36);
                    lotto[3] = allNumbers.Next(1, 36); // This randomizes all of the values inside the array for every index 
                    lotto[4] = allNumbers.Next(1, 36);
                    lotto[5] = allNumbers.Next(1, 36);
                    lotto[6] = allNumbers.Next(1, 36);
                    lotto[7] = allNumbers.Next(1, 36);

                    Array.Sort(lotto); // Sorting the array from lowest to highest number

                    string num1 = $"\n{lotto[0]}";
                    string num2 = $"{lotto[1]}";
                    string num3 = $"{lotto[2]}";
                    string num4 = $"{lotto[3]}"; // This is used to put together a final sentence such that,
                    string num5 = $"{lotto[4]}"; // there can be 2 seconds in-between each new addition
                    string num6 = $"{lotto[5]}";
                    string num7 = $"{lotto[6]}";
                    string joker = $"{lotto[7]}\n";

                    foreach (int num in lotto) // Itterates through all 7 winning number entries
                    {
                        Console.ForegroundColor = ConsoleColor.Green;  // Green is used for all winning numbers

                        Console.Write(num1 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num2 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num3 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num4 + ", ");  // This is used to write each string, while seperating each number entry by a comma,
                        Thread.Sleep(2000);          // and waiting 2 seconds for suspense effect
                        Console.Write(num5 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num6 + ", ");
                        Thread.Sleep(2000);
                        Console.Write(num7 + ", ");

                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.Red; // Red is unique to the joker number, therefore it's outside the forloop

                    Thread.Sleep(2000);

                    Console.Write(" " + joker);  

                    Console.ForegroundColor = ConsoleColor.White; // Change the color to white so the following text doesn't appear red

                    Console.WriteLine("\nPress any key to exit...");

                    Console.ReadKey();

                    Console.Clear(); // Last clear

                    break; // Break out of while loop to close program
                }
            }
        }
    }
}
