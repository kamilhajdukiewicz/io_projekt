using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Lista_produktow:Produkt
    {
        List<int> id_produktu = new List<int>();

        public int get_info()
        {
            return id_produktu[0];
        }
    }
}
