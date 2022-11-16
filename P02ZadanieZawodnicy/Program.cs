using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieZawodnicy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy= mz.WczytajZawodnikow();

            List<string> bledneWiersze =mz.BlednieSformatowaneWiersze;

            foreach (var z in zawodnicy)
                Console.WriteLine(z.Imie + " " + z.Kraj);
            
            if (bledneWiersze.Count>0)
                Console.WriteLine(string.Join("\n", bledneWiersze));

            Console.ReadKey();

        }
    }
}
