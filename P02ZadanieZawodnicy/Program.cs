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
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(TypImportu.Zdalny, url);
            Zawodnik[] zawodnicy= mz.WczytajZawodnikow();

            List<string> bledneWiersze =mz.BlednieSformatowaneWiersze;

            //    mz.BlednieSformatowaneWiersze = new List<string>{ "hej", "ala" };

            string kraj = "pol";
            int liczbaZawodnikow = mz.PodajLiczbeZawodnikow(kraj);
            Console.WriteLine(
                $"Liczba zawodnikow z kraju {kraj} wynosi : {liczbaZawodnikow}"
                );

            foreach (var z in zawodnicy)
                Console.WriteLine(z.Imie + " " + z.Kraj);
            
            if (bledneWiersze.Count>0)
                Console.WriteLine(string.Join("\n", bledneWiersze));


            Console.WriteLine("-------------------");

            GrupaKraj[] gk= mz.PodajSredniWzrost();
            foreach (var g in gk)
            {
                // string s= $"Średni wzrost w kraju {g.NazwaKraju} wynosi {Math.Round(g.SredniWzrost,2)}";
                string s = string.Format("Średni wzrost w kraju {0} wynosi {1:00.00}", g.NazwaKraju, g.SredniWzrost);

                Console.WriteLine(s);
            }

            string s1 =  String.Format("{0:n}", 1234);
            Console.WriteLine(s1);
            Console.ReadKey();

        }
    }
}
