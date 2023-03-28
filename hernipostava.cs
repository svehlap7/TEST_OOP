using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_TEST
{
    internal class hernipostava
    {
        private string jmeno;
        private string prijmeni;
        private int pozx = 0;
        private int pozy = 0;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            private set
            {
                jmeno = Jmeno.ToString();
            }
        }
         public int level = 1;

        public double Pozx
        {
            get
            {
                return pozx;
            }
            private set
            {
            }
        }

        public double Pozy
        {
            get
            {
                return pozy;
            }
            private set
            {
            }
        }

        public hernipostava(string jmeno, string prijmeni)
        {
            this.Jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        //public int Zmenapoz()
        //{

        //}
    }
}
