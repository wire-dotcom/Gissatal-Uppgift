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
        }
    }
}
