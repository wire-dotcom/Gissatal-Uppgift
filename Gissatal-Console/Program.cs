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
            Random rndint = new Random(); // Våran slumpmäsiga int variabel.
            int rndtal = 0; // Definerar en int variabel som alltså kommer att vara talet som spelaren försöker gissa.
            rndtal = rndint.Next(0, 100); // Här sätts värdet på variablen till ett slumpmässigt tal mellan 0 och 100.
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
