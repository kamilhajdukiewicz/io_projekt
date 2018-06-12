using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public abstract class Builder
    {
        public Auto newauto = new Auto();
        public abstract void ustaw_cena();
        public abstract void ustaw_marka();
        public abstract void ustaw_model();
        public abstract void ustaw_rok();
    }
}

