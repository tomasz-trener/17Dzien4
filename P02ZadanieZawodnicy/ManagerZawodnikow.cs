using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieZawodnicy
{
    internal class ManagerZawodnikow
    {
        // public List<string> BlednieSformatowaneWiersze { get;  }

        private List<string> blednieSformatowaneWiersze;
        public List<string> BlednieSformatowaneWiersze
        {
            get { return blednieSformatowaneWiersze; }
           // set { blednieSformatowaneWiersze = value; }
        }


        public Zawodnik[] WczytajZawodnikow()
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string wiersze = wc.DownloadString(url);

            string[] tabWierszy = wiersze.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Zawodnik[] zawodnicy = new Zawodnik[tabWierszy.Length - 1];

            blednieSformatowaneWiersze = new List<string>();
            List<Zawodnik> zawodnicy = new List<Zawodnik>();

            for (int i = 1; i < tabWierszy.Length; i++)
            {
                string[] komorki = tabWierszy[i].Split(';');

                Zawodnik z = new Zawodnik();

                try
                {
                    z.Id_zawodnika = Convert.ToInt32(komorki[0]);

                    if (!string.IsNullOrEmpty(komorki[1]))
                        z.Id_trenera = Convert.ToInt32(komorki[1]);

                    z.Imie = komorki[2];
                    z.Nazwisko = komorki[3];
                    z.Kraj = komorki[4];

                    z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    z.Wzrost = Convert.ToInt32(komorki[6]);
                    z.Waga = Convert.ToInt32(komorki[7]);
                }
                catch (Exception)
                {
                    blednieSformatowaneWiersze.Add(tabWierszy[i]);
                    continue;
                }

                //zawodnicy[i - 1] = z;
                zawodnicy.Add(z);
            }

            return zawodnicy.ToArray();
        }


        public int PodajLiczbeZawodnikow(string kraj)
        {
            Zawodnik[] zawodnicy = WczytajZawodnikow();

            int sum = 0;
            kraj = kraj.ToLower();

            foreach (var z in zawodnicy)
                if (z.Kraj.ToLower() == kraj)
                    sum++;

            return sum;
        }
    }
}
