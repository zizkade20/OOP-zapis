using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Zak
    {
        internal string Jmeno;
        internal string Prijmeni;
        internal int RokNarozeni;
        //int RodneCislo;

        internal Zak() { }
        internal Zak(string _jmeno, string _prijmeni, int _rok_narozeni)
        {
            this.Jmeno = _jmeno;
            this.Prijmeni = _prijmeni;
            this.RokNarozeni = _rok_narozeni;
        }

        private int VratVek()
        {
            return 2022 - RokNarozeni;
        }

        internal void Pozdrav()
        {
            Console.WriteLine("Ahoj, já jsem " + Jmeno + " a je mi " + VratVek().ToString() + " let");
        }
    }
}