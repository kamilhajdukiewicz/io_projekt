using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Uzytkownik : Dane_Klienta
    {
        public Koszyk kosz = new Koszyk();
          
        public Uzytkownik()
        {

        }

        public Uzytkownik(string imie, string nazwisko, int nr, string email, string haslo)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nr = nr;
            this.email = email;
            this.haslo = haslo;
        }

        public void nowy(string im, string na, int nr, string em, string has)
        {
            this.imie = im;
            this.nazwisko = na;
            this.nr = nr;
            this.email = em;
            this.haslo = has;
        }

        public int zmiendane()
        {
            Console.Clear();
            Console.WriteLine("ZMIANA DANYCH");
            Console.WriteLine("-------------");
            Console.Write("Podaj imie: ");
            this.imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            this.nazwisko = Console.ReadLine();
            Console.Write("Podaj nr: ");
            this.nr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj email: ");
            this.email = Console.ReadLine();
            int klucz = 3;
            return klucz;
        }

        public bool czy_zalogowano()
        {
            islogged = true;
            return true;
        }

        public void wyswietl_ogloszenia(Baza_danych b)
        {
            for (int i = 1; i <= b.size_usera(); i++)
            {
                Console.Write(++i + ". ");
                --i;
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", i, b.get_marka(i), b.get_model(i), b.get_rok(i), b.get_przebieg(i), b.get_cena(i));
            }
        }

        public int pokaz_dane()
        {
            Console.Clear();
            Console.WriteLine("TWOJE DANE");
            Console.WriteLine("----------");
            Console.WriteLine("IMIE: " + imie);
            Console.WriteLine("NAZWISKO: " + nazwisko);
            Console.WriteLine("NR: " + nr);
            Console.WriteLine("EMAIL: " + email);
            Console.ReadKey();
            int klucz = 3;
            return klucz;
        }
    }
}
