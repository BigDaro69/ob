using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULATORBMI
{
    public partial class Form1 : Form
    {
        public string plec1 = "";
        public double pal = 0;
        public double ppm = 0;
        List<bmi> bmi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kobieta.Checked) 
            {
                ppm = (double.Parse(waga.Text)*10)+ (6.25 * double.Parse(wzrost.Text)) - (5 * double.Parse(wiek.Text)) - 161;
                plec1 = "KOBIETA";
                if(lista.SelectedIndex== 0) 
                {
                    pal = 1.2;
                }
                else if(lista.SelectedIndex== 1) 
                {
                    pal = 1.3;
                }
                else if (lista.SelectedIndex == 2)
                {
                    pal = 1.5;
                }
                else if (lista.SelectedIndex == 3)
                {
                    pal = 1.6;
                }
                else if (lista.SelectedIndex == 4)
                {
                    pal = 1.9;
                }
                else if (lista.SelectedIndex == 5)
                {
                    pal = 2.2;
                }
            }
            else
            {
                ppm = (double.Parse(waga.Text) * 10) + (6.25 * double.Parse(wzrost.Text)) - (5 * double.Parse(wiek.Text)) + 5;
                plec1 = "Mezczyzna";
                if (lista.SelectedIndex == 0)
                {
                    pal = 1.2;
                }
                else if (lista.SelectedIndex == 1)
                {
                    pal = 1.3;
                }
                else if (lista.SelectedIndex == 2)
                {
                    pal = 1.6;
                }
                else if (lista.SelectedIndex == 3)
                {
                    pal = 1.7;
                }
                else if (lista.SelectedIndex == 4)
                {
                    pal = 2.1;
                }
                else if (lista.SelectedIndex == 5)
                {
                    pal = 2.4;
                }
            }

            bmi bm = new bmi()
            {
                Wiek = double.Parse(wiek.Text),
                Waga = double.Parse(waga.Text),
                Wzrost = double.Parse(wzrost.Text),
                Plec = plec1,
                Bm = double.Parse(waga.Text) / Math.Pow(double.Parse(wzrost.Text) / 100, 2),
                Ppm = ppm,
                Cpm = pal * ppm,
                Aktywnosc = lista.SelectedItem.ToString(),
            };
            MessageBox.Show(bm.wysBMI());
        }


        
        private void wzrost_ValueChanged(object sender, EventArgs e)
        {
            wzrost.Maximum = 1000;
        }

        private void waga_ValueChanged(object sender, EventArgs e)
        {
            wzrost.Maximum = 1000;
        }

        private void wiek_ValueChanged(object sender, EventArgs e)
        {
            wiek.Minimum = 18;
            wiek.Maximum = 99;
        }
    }
}
