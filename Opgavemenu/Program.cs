using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgavemenu{

    class Program{
    
        static void Main (string[] args){
            
            ConsoleKeyInfo cki;
            bool ydre = true;


            while(ydre){
               
                bool indre = true;
                bool exit = false;

                Console.WriteLine("╔══════════════════════════════════════════════════╗");
                Console.WriteLine("║                C# Console opgaver                ║");
                Console.WriteLine("╠══════════════════════════════════════════════════╣");
                Console.WriteLine("║ Opg .1   Matematik                               ║");
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
                    //Opgave 1
                    case ConsoleKey.D1:
                        try
                        {
                        Console.Clear();
                        
                        Console.WriteLine("Vælge første tal: ");
                        
                        decimal input1 = Convert.ToDecimal(Console.ReadLine());
                        
                        Console.WriteLine("Vælge anden tal: ");

                        decimal input2 = Convert.ToDecimal(Console.ReadLine());
                        

                        decimal resultat = input1 * input2 / (input1 - input2) + input2;

                        Console.WriteLine("\nResultat: " + resultat);

                        Thread.Sleep(3000);

                        Console.Clear();
                        } 
                        catch (FormatException)
                        {
                            Console.WriteLine("\nFejl: Forkert format, brug gern heltal eller decimal, f.eks {11, 1.11 eller -11, -1.11} osv." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("\nFejl: Prøvede at dividere med nul.");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nFejl: Tal var enten for stor eller for lille." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                        
                          
                    //Opgave 2
                    case ConsoleKey.D2:
                        Console.Clear();
                        
                        try
                        {
                        Console.WriteLine("Vælge første tal:");
                        double forinput1 = Convert.ToInt64(Console.ReadLine());
                        
                        Console.WriteLine("Vælge anden tal:");
                        double forinput2 = Convert.ToInt64(Console.ReadLine());
                        
                        double forresultat = 0;
                        
                        for(int i = 1; i <= forinput1; i++){
                           forresultat += forinput2;
                        }
                        
                        Console.WriteLine("\nResultat: " + forresultat);
                        Thread.Sleep(3000);
                        Console.Clear();
                        } 
                        catch (FormatException)
                        {
                            Console.WriteLine("\nFejl: Forkert format, brug heltal {11, 1, -11, -1} osv." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nFejl: Tal var enten for stor eller for lille." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                     
                        break;
                    //Opgave 3    
                    case ConsoleKey.D3:
                        
                       try
                       {
                            Console.Clear();
                            
                            Console.WriteLine("Vælge fakultet nummer:");
                            
                            double n = Convert.ToInt64(Console.ReadLine());
                            double fkresult = 1;
                            
                            for (int i = 1; i <= n; i++)
                            {
                                fkresult *= i;
                            }
                            
                            Console.WriteLine("\nResultat: " + fkresult);

                            Thread.Sleep(3000);

                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nFejl: Forkert format, brug heltal {11, 1, -11, -1} osv." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nFejl: Tal var enten for stor eller for lille." );
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                    //Opgave 4
                    case ConsoleKey.D4:
                        try
                        {
                            while(indre)
                            {
                                Console.Clear();
                                
                                ConsoleKeyInfo fcki;

                                Console.WriteLine("╔════════════════════════════════╗");
                                Console.WriteLine("║      Fil Valgmulighedere       ║");
                                Console.WriteLine("╠════════════════════════════════╣");
                                Console.WriteLine("║ Mulig .1  Skriv og gem til C:/ ║");
                                Console.WriteLine("║ Mulig .2  Tilføj tekst og gem  ║");
                                Console.WriteLine("║ Mulig .3  Læs fil og udskriv   ║");
                                Console.WriteLine("║ Tast 'Q' for gå tilbage        ║"); 
                                Console.WriteLine("╚════════════════════════════════╝");

                                fcki = Console.ReadKey();
                                
                                //Valgmuligheder for filen.
                                switch(fcki.Key)
                                {
                                    //Opret fil, skriv tekst og gem med navn.
                                    case ConsoleKey.D1:
                                        try    
                                        {    
                                            Console.Clear();
                                            
                                            Console.WriteLine("Vælge fil navn:");
                                            
                                            string? filnavnM1 = Console.ReadLine();
                                            
                                            string pathM1 = "C:\\temp\\" + filnavnM1 + ".txt";

                                            FileStream filM1 = new FileStream(pathM1, FileMode.Create, FileAccess.ReadWrite);
                                            
                                            Console.WriteLine("\nSkrev fil: " + filnavnM1 + ".txt");
                                            
                                            Console.WriteLine("\nSkriv tekst til fil:");
                                            
                                            string? filtekstM1 = Console.ReadLine();
                                              
                                            using (StreamWriter swM1 = new StreamWriter(filM1))
                                            {

                                                swM1.WriteLine(filtekstM1);

                                                swM1.Flush(); 
                                            
                                            }

                                            Console.WriteLine("\nTekst er skrevet til filen.");
                                            
                                            Thread.Sleep(3000);
                                            
                                            Console.Clear();

                                            exit = true;    
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new Exception("\nFejl: " + ex.Message);
                                        }
                                        break;
                                    //Tilføj tekst og gem .
                                    case ConsoleKey.D2:
                                        try
                                        {    
                                            Console.Clear();

                                            Console.WriteLine("Vælge fil navn:");
                                            
                                            string? filnavnM2 = Console.ReadLine();
                                            
                                            string pathM2 = "C:\\temp\\" + filnavnM2 + ".txt";

                                            if (!File.Exists(pathM2)){Console.WriteLine("\nFil eksistere ikke!"); Thread.Sleep(3000); break;}

                                            Console.WriteLine("\nSkriv nyt linje til fil: " + filnavnM2);
                                            
                                            string? filtekstM2 = Console.ReadLine();

                                            using (StreamWriter swM1 = File.AppendText(pathM2))
                                            {

                                                swM1.WriteLine(filtekstM2);

                                                swM1.Flush(); 
                                            
                                            }

                                            Console.WriteLine("\nTekst er skrevet til filen.");
                                            
                                            Thread.Sleep(3000);
                                            
                                            Console.Clear();

                                            exit = true;    
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("\nFejl: " + ex.Message);
                                        }
                                        break;
                                    
                                    case ConsoleKey.D3:
                                        try
                                        {
                                            Console.Clear();

                                            Console.WriteLine("Vælge fil navn:");

                                            string? filnavnM3 = Console.ReadLine();
                                            
                                            string pathM3 = "C:\\temp\\" + filnavnM3 + ".txt";

                                            if (!File.Exists(pathM3)){Console.WriteLine("\nFil eksistere ikke!"); Thread.Sleep(3000); break;}
                                            
                                            Console.WriteLine("\nFil indhold: ");

                                            using (StreamReader sr = new StreamReader(pathM3)) 
                                            {
                                                string indhold = sr.ReadToEnd();
                                                Console.WriteLine(indhold);
                                                Thread.Sleep(10000);
                                            }
                                        
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("\nFejl: " + ex.Message);
                                        }
                                        break;
                                    
                                    case ConsoleKey.Q:
                                        
                                        exit = true;

                                        Console.Clear();

                                        break;
                                        
                                    default:
                                        break;
                                }
                                if (exit)
                                {
                                    break;
                                }
                            }   
                        }
                        catch
                        {

                        }
                        break;
                    //Opgave 5
                    case ConsoleKey.D5:
                        try
                        {
                            while(true){
                                
                                Console.Clear();
                                
                                Console.WriteLine("Vælge json fil:");
                                
                                string jsonnavn = Console.ReadLine() + ".json";
                                
                                string pathJson = "C:\\temp\\" + jsonnavn;

                                

                                if (!File.Exists(pathJson)){Console.WriteLine("\nFil eksistere ikke!"); Thread.Sleep(3000); Console.Clear(); break;}

                                //Åben, læs og udskriv indhold af fil

                                using (StreamReader sr = new StreamReader(pathJson)) 
                                {
                                    string indhold = sr.ReadToEnd();
                                    Console.WriteLine("\n" + indhold);
                                }

                                //Læs json data og validere med regex

                                string? jsonData = "\n" + Console.ReadLine();

                                string tiladtdata = @"\{""[^""]+"":""[^""]+""(, *""[^""]+"":""[^""]+"")*\}";

                                if (!Regex.IsMatch(jsonData, tiladtdata))
                                {
                                    Console.WriteLine("Forkert format");
                                    
                                    Thread.Sleep(3000);

                                    Console.Clear();

                                    break;
                                }

                                //Skriv nyt json data ind

                                File.AppendAllText(pathJson, jsonData);

                                Thread.Sleep(3000);

                                Console.Clear();
                        
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nFejl: " + ex.Message);
                            Thread.Sleep(3000);
                        }

                        break;
                        
                    //Opgave 6
                    case ConsoleKey.D6:
                        Console.Clear();
                        
                        break;
                    //Opgave 7
                    case ConsoleKey.D7:
                        Console.Clear();
                        Console.WriteLine("test 7");
                        break;
                    //Luk program
                    case ConsoleKey.Q:
                        Console.Clear();
                        Environment.Exit(0);
                        break;    
                    //Continue som default
                    default:
                        Console.Clear();
                        continue;

                }   
            }
        }
    }
}     