using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Wypozyczenie
    {
        public  Czytelnik Czytelnik { get; set; }
        public  DateTime DataWypozyczenia { get; set; }
        public  DateTime DataPrzewidywanegoZwrotu { get; set; }
        public  DateTime DataRzczywistegoZwrotu { get; set; }
        public  Sygnatura Sygnatura { get; set; }
        public  string Uwagi { get; set; }
        public  Wypozyczenie Przedluzenie { get; set; }
        public  double Kara { get; set; }
    }
}
