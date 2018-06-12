using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Czesc : Builder
        {
        
        public string nazwa;
        public string stan;
        public string rok;

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
    }
}
