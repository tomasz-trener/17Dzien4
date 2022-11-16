using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieBiblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karta k = new Karta();
            //k.NrKarty = "1308/00";

            //.....


            Karta k = new Karta()
            {
                NrKarty = "1308/00",
                Tytul = "O kurdlach dla opornych",
                Wydanie = 1,
                Autorzy = new Autor[2]
                {
                    new Autor()
                    {
                        Imie = "L",
                        Nazwisko = "Tarantoga",
                        DrugieImie = "A"
                    },
                    new Autor()
                    {
                        Imie = "I",
                        Nazwisko = "Tichy",
                    }
                },
                DataZakupu = new DateTime(2000, 1, 27),
                Cena = new Cena()
                {
                    CenaWlasciwa = 17.5,
                    Komentarz = "zakup z 18.08 - 20,00"
                },
                Sygnatury = new List<Sygnatura>()
                {
                    new Sygnatura()
                    {
                        Aktywna=  false,
                        Komentarz = "zgłoszona utrata 01.05.2000",
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik = new Czytelnik()
                                {
                                    NrKarty= "A1427",
                                },
                                DataWypozyczenia = new DateTime(2000,1,31),
                                DataPrzewidywanegoZwrotu = new DateTime(2000,2,15),
                            }
                        }
                    }

                }
            };


            string nrKarty = k.Sygnatury[0].Wypozyczenia[0].Czytelnik.NrKarty;
            Console.WriteLine(nrKarty);



        }
    }
}
