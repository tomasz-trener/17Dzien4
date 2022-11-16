﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Sygnatura
    {
        public  int NrSygnatury { get; set; }
        public  string Komentarz { get; set; }
        public  List<Wypozyczenie> Wypozyczenia { get; set; }
        public  bool Aktywna { get; set; }
        public  Karta Karta { get; set; }
    }
}
