namespace SortingHat
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            SortingHat sortingHat = new SortingHat();

            string hat = sortingHat.Hat();

                switch (hat)
                {
                    case "Gryffindor":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(hat);
                        break;
                    case "Hufflepuff":
                        Console.ForegroundColor  = ConsoleColor.Red;
                        Console.WriteLine(hat);
                        break;
                    case "Ravenclaw":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(hat);
                        break;
                    case "Slytherin":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(hat);
                        break;
                    default:
                        break;
                }
                
            
        }
    }
        
}
