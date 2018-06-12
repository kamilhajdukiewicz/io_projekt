using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    class Ogloszenie
    {
        
        string nazwa;

        Auto aut = new Auto();
        public Ogloszenie(Baza_danych b)
        {
            aut.id=aut.get_id(b);
        }
        public void dodaj(Baza_danych b)
        {
            Console.Clear();
            Console.WriteLine("Podaj marke: ");
            string ma = Console.ReadLine();
            Console.WriteLine("Podaj model: ");
            string mo = Console.ReadLine();
            Console.WriteLine("Podaj rok: ");
            int ro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj przebieg: ");
            int pr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cene : ");
            int ce = Convert.ToInt32(Console.ReadLine());
            aut = new Auto(aut.id,ma, mo, ro, pr, ce);
            b.insert_aut(aut.id, aut.marka, aut.model, aut.rok, aut.przebieg, aut.cena);
        }
        public void dodaj_zdjecie()
        {

        }
        public void wyswietl_oferte()
        {

        }

    }
}
