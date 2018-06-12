using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Auto_ciezarowe:Builder
    {
        public int id;
        public int cena;
        public string marka;
        public string model;
        public int rok;
        public int przebieg;
        public int pojemnosc;

        private Auto_ciezarowe au = new Auto_ciezarowe();
        public override void ustaw_cena()
        {
            throw new NotImplementedException();
        }

        public override void ustaw_marka()
        {
            throw new NotImplementedException();
        }

        public override void ustaw_model()
        {
            throw new NotImplementedException();
        }

        public override void ustaw_rok()
        {
            throw new NotImplementedException();
        }
        public Auto_ciezarowe()
        {
        }

        public Auto_ciezarowe(int id, string marka, string model, int rok, int przebieg, int cena,int pojemnosc)
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.rok = rok;
            this.przebieg = przebieg;
            this.cena = cena;
            this.pojemnosc = pojemnosc;
        }
    }
}
