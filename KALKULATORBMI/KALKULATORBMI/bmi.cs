using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULATORBMI
{
    public class bmi
    {
        private double wiek;
        private double waga;
        private double wzrost;
        private string plec;
        private double bm;
        private double ppm;
        private double cpm;
        private string aktywnosc;



        public double Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        public double Waga
        { get { return waga; }
          set { waga = value; }
        }

        public double Wzrost
        { get { return wzrost; }
          set { wzrost = value; }
        }

        public string Plec
        { get { return plec; }
          set { plec = value; }  
        }

        public double Bm
        { get { return bm; }
          set { bm = value; }
        }
        public double Ppm
        { get { return ppm; }
            set
            {
                ppm = value;
            }
        }
        
        public double Cpm
        {
            get { return  cpm; }
            set { cpm = value; }
        }

        public string Aktywnosc
        {
            get { return aktywnosc;}
            set
            {
                aktywnosc = value;
            }
        }


        public bmi()
        {
            wiek = 0;
            waga = 0;
            wzrost = 0;
            plec = "";
            bm = 0;
            ppm = 0;
            cpm = 0;
            aktywnosc = "";
        }

        public bmi(double wiek, double waga, double wzrost, string plec, double bm, double ppm, double cpm, string aktywnosc)
        {
            this.wiek = wiek;
            this.waga = waga;
            this.wzrost= wzrost;
            this.plec = plec;
            this.bm = bm;
            this.ppm = ppm;
            this.cpm = cpm;
            this.aktywnosc= aktywnosc;
            
        }

        public string wysBMI()
        {
            return ("Wiek: " + wiek + ", Waga: " + waga + ", Wzrost: " + wzrost + ", Plec: " + plec + ", BMI: " + bm + ", PPM: " + ppm + ", CPM:  " + cpm + ", Aktywność: " + aktywnosc);
        }
    }
}

    

