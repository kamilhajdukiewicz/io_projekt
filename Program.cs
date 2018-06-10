using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemMan sys = new SystemMan();
            Baza_danych b = new Baza_danych();
            int klucz=0;
            while (true)
            {
                
                if (klucz == 1 || klucz==0)
                {
                    klucz=sys.mainpanel();
                    if (klucz == 5)
                        klucz = sys.zarejestruj();
                    if (klucz == 6)
                        klucz = sys.zaloguj();
                }
                if (klucz == 2)
                {
                    klucz=sys.przegladaj(b);
                }
                if (klucz == 3)
                {
                    klucz=sys.mojekonto();
                }
                if (klucz == 4)
                {
                    klucz=sys.koszyk();
                }
            }

            Console.ReadKey();
        }
    }
}
