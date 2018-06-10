using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    class SystemMan
    {
        Uzytkownik user = new io_projekt_cs.Uzytkownik();
        public int mainpanel()
        {
            Console.Clear();
            Console.WriteLine("STRONA GLOWNA");
            Console.WriteLine("-------------");
            Console.WriteLine("1. Strona Główna");
            Console.WriteLine("2. Przeglądaj");
            Console.WriteLine("3. Moje konto");
            Console.WriteLine("4. Koszyk");
            Console.WriteLine("-------------");
            Console.WriteLine("5. Zarejestruj się");
            Console.WriteLine("6. Zaloguj się");
            int klucz = Convert.ToInt32(Console.ReadLine());
            return klucz;
        }

        public int przegladaj(Baza_danych b)
        {
            Console.Clear();
            Console.WriteLine("PRZEGLĄDAJ OFERTY");
            Console.WriteLine("-------------");
            for(int i=1;i<=b.size();i++)
            {
                Console.Write(++i + ". ");
                --i;
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", i, b.get_marka(i), b.get_model(i), b.get_rok(i), b.get_przebieg(i), b.get_cena(i));
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Aby wrocic kliknij 0");
            Console.WriteLine("Aby dodac ogloszenia kliknij 98");
            Console.WriteLine("Aby dodac ogloszenie do koszyka wcisnij numer ogloszenia");

            int klucz = Convert.ToInt32(Console.ReadLine());
            
            if(klucz==98)
            {
                Ogloszenie ogl = new Ogloszenie(b);
                ogl.dodaj(b);
                Console.WriteLine("Twoje ogłoszenie dodano poprawnie");
                Console.ReadKey();
                klucz = 0;
            }
            else if(klucz!=0 && klucz!=1)
            {
                //dodawanie do koszyka
            }
            return klucz;
        }

        public int mojekonto()
        {
            if (user.islogged)
            {
                Console.Clear();
                Console.WriteLine("MOJE KONTO");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Strona Główna");
                Console.WriteLine("2. Przeglądaj");
                Console.WriteLine("3. Moje konto");
                Console.WriteLine("4. Koszyk");
                Console.WriteLine("-------------");
                Console.WriteLine("5. Wyswietl swoje ogloszenia");
                int klucz = Convert.ToInt32(Console.ReadLine());
                return klucz;
            }
            else
            {
                Console.WriteLine("Musisz być zalogowany");
                Console.ReadKey();
                int klucz = 1;
                return klucz;
            }
        }
        public int koszyk()
        {
            if (user.islogged)
            {
                Console.Clear();
                Console.WriteLine("KOSZYK");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Strona Główna");
                Console.WriteLine("2. Przeglądaj");
                Console.WriteLine("3. Moje konto");
                Console.WriteLine("4. Koszyk");
                Console.WriteLine("-------------");
                int klucz = Convert.ToInt32(Console.ReadLine());
                return klucz;
            }
            else
            {
                Console.WriteLine("Musisz być zalogowany");
                Console.ReadKey();
                int klucz = 1;
                return klucz;
            }
        }
        public int zarejestruj()
        {
            Console.Clear();
            Console.Write("Podaj imie: ");
            string im = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string na = Console.ReadLine();
            Console.Write("Podaj numer: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj email: ");
            string em = Console.ReadLine();
            Console.Write("Podaj haslo: ");
            string ha = Console.ReadLine();
            user.nowy(im, na, nr, em, ha);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Rejestracja przebiegła pomyślnie");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Aby wrocic kliknij 1");
            int klucz = Convert.ToInt32(Console.ReadLine());
            return klucz;
        }

        public int zaloguj()
        {
            Console.Clear();
            Console.Write("Podaj email: ");
            string em = Console.ReadLine();
            Console.Write("Podaj haslo: ");
            string ha = Console.ReadLine();
            if(em==user.email && ha==user.haslo)
            {
                Console.WriteLine("Zalogowano poprawnie");
                user.czy_zalogowano();
            }
            else
            {
                Console.WriteLine("Niezalogowano");
            }
            Console.WriteLine("Aby wrocic kliknij 1");
            int klucz = Convert.ToInt32(Console.ReadLine());
            return klucz;
        }
        public int wyswiel_ogloszenia(Baza_danych b)
        {
            for (int i = 1; i <= b.size_usera(); i++)
            {
                int k = i + 1;
                Console.Write(k + ". ");
                int[] idd = b.get_id_us(b.size_usera());
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", idd, b.get_marka_us(idd[--i]), b.get_model_us(idd[--i]), b.get_rok_us(idd[0]), b.get_przebieg_us(idd[0]), b.get_cena_us(idd[0]));
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Aby wrocic kliknij 1");
            int klucz = Convert.ToInt32(Console.ReadLine());
            return klucz;
        }
    }
}
