using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Auto : Produkt
    {
        public string marka;
        public string model;
        public int rok;
        public int przebieg;

        public int get_id(Baza_danych b)
        {
            this.id = 1+b.size();
            return this.id;
        }

        public Auto(int id, string marka, string model, int rok, int przebieg, int cena)
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.rok = rok;
            this.przebieg = przebieg;
            this.cena = cena;
        }
        public Auto()
        {

        }

    }
}
