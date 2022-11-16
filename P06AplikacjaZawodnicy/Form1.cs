using P02ZadanieZawodnicy.Domain;
using P02ZadanieZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            lblDane.Items.Clear();
            
            ManagerZawodnikow mz = new ManagerZawodnikow(TypImportu.Zdalny, txtUrl.Text);
            mz.WczytajZawodnikow();
            Zawodnik[] zawodnicy = mz.PodajZawodnikow(txtKraj.Text);

            foreach (var z in zawodnicy)
            {
                lblDane.Items.Add(z.Imie + " " + z.Nazwisko);
            }

        }
    }
}
