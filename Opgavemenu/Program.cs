using System.Security.Cryptography;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavemenu{

    class Program{
    
        static void Main (string[] args){
            ConsoleKeyInfo cki;

            while(true){  
                Console.WriteLine("╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║                C# Console opgaver                ║");
                Console.WriteLine("╠══════════════════════════════════════════════════╣");
                Console.WriteLine("║ Opg. 1   Matematik                               ║");
                Console.WriteLine("║ Opg .2   Loop med summering                      ║");
                Console.WriteLine("║ Opg .3   Beregne fakultet af et tal              ║");  
                Console.WriteLine("║ Opg .4   Læs og skriv til en fil                 ║");
                Console.WriteLine("║ Opg .5   JSON string editor og syntaks checker   ║");
                Console.WriteLine("║ Opg .6   Email checker - med loop, If, regler    ║");
                Console.WriteLine("║ Opg .7   Email checker - regulær udtryk          ║");
                Console.WriteLine("║ Tast et tal 1 - 7 eller q for at afslutte.       ║");
                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                cki = Console.ReadKey();
                
                switch (cki.Key) {
                    case ConsoleKey.D1:
                        retry:
                        Console.Clear();
                        
                        Console.WriteLine("Vælge første tal: ");
                        
                        string input1 = Console.ReadLine();
                        
                        Console.WriteLine("Vælge anden tal: ");

                        string input2 = Console.ReadLine();
                        
                        double parsedTal1;
                        double parsedTal2;
                                                             
                        if (!double.TryParse(input1, out parsedTal1))
                        {
                            Console.WriteLine("Brug rigtig format: 10 (ikke '1 0' osv.)");
                            Thread.Sleep(5000);
                            goto retry;
                        }

                        if (!double.TryParse(input2, out parsedTal2))
                        {
                            Console.WriteLine("Brug rigtig format: 10 (ikke '1 0' osv.)");
                            Thread.Sleep(5000);
                            goto retry;
                        }
                    
                        double resultat = parsedTal1 * parsedTal2 / (parsedTal1 - parsedTal2) + parsedTal2;
                        
                        if (parsedTal1 == parsedTal2)
                        {
                            Console.WriteLine("Divison by 0 - error");
                            Console.WriteLine("Tryk på Q for at gå tilbage til opgavemenu.");

                            ConsoleKeyInfo exit = Console.ReadKey();

                            if(exit.Key == ConsoleKey.Q)
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                continue;
                            }
                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("Resultat: " + resultat);

                            Console.WriteLine("Tryk på Q for at gå tilbage til opgavemenu.");

                            ConsoleKeyInfo exit = Console.ReadKey();

                            if(exit.Key == ConsoleKey.Q)
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                continue;
                            }
                        }

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