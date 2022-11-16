using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Karta
    {
        public string NrKarty { get; set; }
        public string Tytul { get; set; }
        public  int Wydanie { get; set; }
        public  DateTime DataZakupu { get; set; }
        public  Karta Nastepna { get; set; }
        public  Karta Poprzednia { get; set; }
        public  List<Sygnatura> Sygnatury { get; set; }
        public  Cena Cena { get; set; }
        public  Autor[] Autorzy { get; set; }
    }
}
