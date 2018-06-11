using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Koszyk
    {
        public int koszt;
        public int ceny=0;
        public int prowizja;
        public int ilosc;
        public List<int> id_pr=new List<int>();
        public Koszyk()
        {

        }
        public int oblicz_koszt(Baza_danych b)
        {
            ilosc = id_pr.Count;
            for(int i=0;i<ilosc;i++)
            {
                ceny=ceny+b.get_cena_koszyk(id_pr[i]);
            }
            return ceny;
        }
        public int oblicz_prowizje()
        {
            prowizja = Convert.ToInt32(0.1 * ceny);
            return prowizja;
        }
        public int caly_koszt()
        {
            koszt = ceny + prowizja;
            return koszt;
        }
        public void zeruj()
        {
            koszt = 0;
            ceny = 0;
            prowizja = 0;
            ilosc = 0;
        }
        public void aktualizuj(int id, Baza_danych b)
        {
            ceny = ceny - b.get_cena_ko(id);
            prowizja = oblicz_prowizje();
            koszt = caly_koszt();
        
        }
        public void wyswietl_koszyk(Baza_danych b)
        {
            for (int i = 1; i <= id_pr.Count(); i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", id_pr[i - 1], b.get_marka_us(id_pr[i - 1]), b.get_model_us(id_pr[i - 1]), b.get_rok_us(id_pr[i - 1]), b.get_przebieg_us(id_pr[i - 1]), b.get_cena_us(id_pr[i - 1]));
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Koszt przedmiotow = " + oblicz_koszt(b));
            Console.WriteLine("Prowizja = " + oblicz_prowizje());
            Console.WriteLine("Łaczny koszt = " + caly_koszt());

        }
    }
}
