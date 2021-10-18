using System;
// lite nersaktning?
using System.Threading;

namespace Gissa_talet
{
    class Program
    {
        static void Main(string[] args)
        {

            //färg
            Console.ForegroundColor = ConsoleColor.White;

            //Random tal
            Random r = new Random();

            //senaste vinnaren
            string Senastevinnaren = "Ingen har vunnit än";

            Console.WriteLine("Välkommen till Gissa Talet");
            Thread.Sleep(1500);
            Console.WriteLine();

            // Sätt menyVal till "0"
            String menyval = "0";

            while (menyval != "4")
            {
                // Skriv ut meny
                Console.WriteLine("Välj ett av alternativ nedan");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine("1. Spela Gissa Talet");
                Thread.Sleep(500);
                Console.WriteLine("2. Visa senaste vinnaren");
                Thread.Sleep(500);
                Console.WriteLine("3. Spelets regler");
                Thread.Sleep(500);
                Console.WriteLine("4. Avsluta programmet");

                // Läs in menyVal
                menyval = Console.ReadLine();

                // Tom rad för fint
                Console.WriteLine();
               
                // switch menyVal
                switch (menyval)
                {
                   
                    // case 1: Spela en omgång av Gissa talet
                    case "1":

                        bool valid = false;
                        int gissning;
                        int Talet = 0;
                        int min = 0;
                        int max;

                        Console.WriteLine();
                        Console.WriteLine("Skriv in det högsta talet du vill gissa");
                        max = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Talet += r.Next(min, max);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Talet skapas");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.WriteLine("Talet är klart du kan börja gissa");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();

                        Console.WriteLine($"Talet är mellan 1 och {max}");

                        while (valid == false)
                        {
                            // låt användaren gissa talet
                            valid = int.TryParse(Console.ReadLine(), out gissning);

                            while (gissning != Talet)
                            {
                                //gör så bara siffror skrivs om ej skrivs så få ett fel meddelande
                                if (!valid)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Fel inmatning, du måste mata in en siffra");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine();

                                }
                                // säga till om det är högre eller lägre
                                if (gissning < Talet && valid)
                                {
                                    Console.WriteLine($"Du gissade talet {gissning} vilket är för lågt");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("Försök igen");

                                }
                                if (gissning > Talet && valid)
                                {
                                    Console.WriteLine($"Du gissade talet {gissning} vilket är för högt");
                                    Thread.Sleep(500);
                                    Console.WriteLine();
                                    Console.WriteLine("Försök igen");
                                }
                                valid = int.TryParse(Console.ReadLine(), out gissning);
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du gissade rätt tal och vann, Bra jobbat");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Thread.Sleep(1000);

                        Console.WriteLine("Skriv in ditt namn för att vissa att du van senast");
                        Senastevinnaren = Console.ReadLine();

                        break;

                    // case 2: Visa senaste vinnaren
                    case "2":
                        Console.WriteLine("Senaste vinnaren: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{Senastevinnaren}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.WriteLine();
                        break;

                    // case 3: Visa spelets regler
                    case "3":
                        Console.WriteLine("Spelet går ut på att du ska försöka att gissa ett tal mellan 1-10"); 
                        Console.WriteLine("medans du får hjälp utav datorn om talet är för högt eller för lågt");
                        Console.WriteLine("från vad du gissade senast.");
                        Thread.Sleep(7500);
                        Console.WriteLine("När du har gissat rätt tal så vinner du spelet, ganska enkelt va");
                        Thread.Sleep(2500);
                        Console.WriteLine("Kör programmet igen och testa :)");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        break;

                    // case 4: Programmet avslutas (bara break)
                    case "4":
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tack för att du spelade hoppades du hade en bra stund :)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        break;

                    // default: Skriv att alternativet var ogiltigt
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(500);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
