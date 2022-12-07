using oop;
using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            // ...

            Zak Zak1 = new Zak();
            Zak1.Jmeno = "Peter";
            Zak1.Prijmeni = "Kubín";
            Zak1.RokNarozeni = 2004;

            Zak Zak2 = new Zak()
            {
                Jmeno = "Generál",
                Prijmeni = "Pavel",
                RokNarozeni = 1980
            };

            Zak zak3 = new Zak(
                "George",
                "Oracle",
                1221);
            Zak1.Pozdrav();
        }
    }
}