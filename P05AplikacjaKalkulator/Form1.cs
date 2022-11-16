using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05AplikacjaKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJeden_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "1";
        }

        private void btnDwa_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "2";
        }


        private void btnTrzy_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text += "3";
        }

        // Jedna wspólna metoda dla pozostałych przycisków 
        private void btnPrzycisk_Click(object sender, EventArgs e)
        {
            // z sendera trzeba wypakowac przycisk 

            Button b = (Button)sender; // wypakowanie z obiektu przycisku, który został wciśniety 

            // w zmiennej b jest uchyt do przycisku, który został wciśnięty 

            txtWyswietlacz.Text += b.Text;
        }

        private void btnRownaSie_Click(object sender, EventArgs e)
        {
            // rola metod obsłgujacych zdarzenia :
            //1) wczytanie danych z interfejsu
            //2) prośba o wykonanie operacji przez klasę
            //3) wyświetlenie wyniku na interfejsie 

            string rownanie = txtWyswietlacz.Text;
           
            // nie wolno umieszczać kodu przetwarajacego
            // dane w klasie obsługującej interfejs 

            Kalkulator k = new Kalkulator();
            double wynik = k.WykonajDzialanie(rownanie);

            //txtWyswietlacz.Text = wynik.ToString();
            txtWyswietlacz.Text = Convert.ToString(wynik);
        }

        private void btnCzysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "";
        }
    }
}
