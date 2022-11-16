using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPowitanie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("heej");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNazwisko.Text = "Kowalski";
            txtImie.Text = "Jan";
        }

        private void btnZakoncz_Click(object sender, EventArgs e)
        {

        }
    }
}
