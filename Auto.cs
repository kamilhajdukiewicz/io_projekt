using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Auto 
    {
        public int id;
        public int cena;
        public string marka;
        public string model;
        public int rok;
        public int przebieg;
        public int get_id(Baza_danych b)
        {
            this.id = 1+b.size();
            return this.id;
        }

        //public override void ustaw_cena()
        //{
        //    newauto.cena = cena;
        //}

        //public override void ustaw_marka()
        //{
        //    newauto.marka = marka;
        //}

        //public override void ustaw_model()
        //{
        //    newauto.model = model;
        //}

        //public override void ustaw_rok()
        //{
        //    newauto.rok = rok;
        //}

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
