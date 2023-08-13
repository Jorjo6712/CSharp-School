namespace Morsecode
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Morsecode converter\n");

            Console.WriteLine("Write a sentence: \n");

            string? input = Console.ReadLine();

            char[]? array = input.ToCharArray();

            List<string> sentence = new List<string>();
            foreach (char c in array)
            {
                switch (c)
                {
                    case 'a':
                        sentence.Add(".-");
                        break;
                    case 'b':
                        sentence.Add("-...");
                        break;
                    case 'c':
                        sentence.Add("-.-.");
                        break;
                    case 'd':
                        sentence.Add("-..");
                        break;
                    case 'e':
                        sentence.Add(".");
                        break;
                    case 'f':
                        sentence.Add("..-.");
                        break;
                    case 'g': 
                        sentence.Add("--.");
                        break;
                    case 'h':
                        sentence.Add("....");
                        break;
                    case 'i':
                        sentence.Add("..");
                        break;
                    case 'j':
                        sentence.Add(".---");
                        break;
                    case 'k':
                        sentence.Add("-.-");
                        break;
                    case 'l':
                        sentence.Add(".-..");
                        break;
                    case 'n':
                        sentence.Add("-.");
                        break;
                    case 'm':
                        sentence.Add("--");
                        break;
                    case 'o':
                        sentence.Add("---");
                        break;
                    case 'p':
                        sentence.Add(".--.");
                        break;
                    case 'q':
                        sentence.Add("--.-");
                        break;
                    case 'r':
                        sentence.Add(".-.");
                        break;
                    case 's':
                        sentence.Add("...");
                        break;
                    case 't':
                        sentence.Add("-");
                        break;
                    case 'u':
                        sentence.Add("..-");
                        break;
                    case 'v':
                        sentence.Add("...-");
                        break;
                    case 'w':
                        sentence.Add(".--");
                        break;
                    case 'x':
                        sentence.Add("-..-");
                        break;
                    case 'y':
                        sentence.Add("-.--");
                        break;
                    case 'z':
                        sentence.Add("--..");
                        break;
                    case '1':
                        sentence.Add(".----");
                        break;
                    case '2':
                        sentence.Add("..---");
                        break;
                    case '3':
                        sentence.Add("...--");
                        break;
                    case '4':
                        sentence.Add("....-");
                        break;
                    case '5':
                        sentence.Add(".....");
                        break;
                    case '6':
                        sentence.Add("-....");
                        break;
                    case '7':
                        sentence.Add("--...");
                        break;
                    case '8':
                        sentence.Add("---..");
                        break;
                    case '9':
                        sentence.Add("----.");
                        break;
                    case '0':
                        sentence.Add("-----");
                        break;
                    default:
                        break;               
                }
            }

            string result = string.Join(" ",sentence);

            Console.WriteLine($"\nYour sentence in morse code is: [{result}]");

            Console.WriteLine("\nPress any key to exit...\n");
            
            Console.ReadKey();

            Console.Clear();
        }
    }
}