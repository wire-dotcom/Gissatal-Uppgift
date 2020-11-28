using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissatal_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndint = new Random(); // Våran slumpmässiga Random variabel.            
            int rndtal = rndint.Next(1, 101); // Skapar en in som upptar ett slumpmässigt värde mellan 1 och 100 med hjälp av våran slumpmässiga Random variabel.
            int antalGuess = 0;            
            Console.WriteLine("Jag har valt ett tal, gissa vilket");
            
            while (true) // Den här biten av spelet är i en while (true) loop så att vi kan upprepa den eller avsluta den när vi vill.
            {
                string strGuess = Console.ReadLine();
                int intGuess = Convert.ToInt32(strGuess);
                Console.Clear();
                antalGuess++;
                if (intGuess == rndtal)
                {
                    Console.WriteLine("Du har gissat rätt!");
                    if (antalGuess >= 10)
                        Console.WriteLine("Det tog dig " + antalGuess + " försök");
                    else
                        Console.WriteLine("Det tog dig bara " + antalGuess + " försök");
                    break;
                }
                else if (intGuess > rndtal)
                {
                    Console.WriteLine("Fel! Du har gissat för högt! Försök igen");

                }
                else
                {
                    Console.WriteLine("Fel! Du har gissat för lågt! Försök igen");
                }    

            }
        }
    }
}
