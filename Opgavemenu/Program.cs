using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavemenu{

    class Program{
    
        static void Main (string[] args){
            ConsoleKeyInfo cki;
            while (true){
                Console.WriteLine("C# Console opgaver ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Opg. 1   Matematik ");
                Console.WriteLine("Opg .2   Loop med summering");
                Console.WriteLine("Opg .3   Beregne fakultet af et tal");
                Console.WriteLine("Opg .4   Læs og skriv til en fil");
                Console.WriteLine("Opg .5   JSON string editor og syntaks checker");
                Console.WriteLine("Opg .6   Email checker - med loop, If, regler");
                Console.WriteLine("Opg .7   Email checker - regulær udtryk");
                Console.WriteLine("----------------------------------");
                cki = Console.ReadKey();
                switch (cki.Key) {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("test");
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("test 2");
                        break;
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("test 3");
                        break;
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("test 4");
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("test 5");
                        break;
                    case ConsoleKey.D6:
                        Console.Clear();
                        Console.WriteLine("test 6");
                        break;
                    case ConsoleKey.D7:
                        Console.Clear();
                        Console.WriteLine("test 7");
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        Environment.Exit(0);
                        break;    
                    default:
                        try
                        { 
                            throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            continue;
                        }
                      
                }   
            }
        }
    }
}     