namespace Rumfanget 
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            
            Console.WriteLine("Box Volume Calculator \n");
            
            Console.WriteLine("Write your height: ");
            
            int height = Convert.ToInt32(Console.ReadLine()); // Reads height from user input
            
            Console.WriteLine("Write your width: ");

            int width = Convert.ToInt32(Console.ReadLine()); // Reads width from user input

            Console.WriteLine("Write your length: ");

            int length = Convert.ToInt32(Console.ReadLine()); // Reads length from user input

            int result = height * width * length; // Multiplies height, width and length and stores in result

            Console.WriteLine($"\nResulat: {result} \n"); // Prints result to console

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
            
        }
    }
}