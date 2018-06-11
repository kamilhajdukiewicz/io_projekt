using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    class SystemMan : Singleton
    {
        public Uzytkownik user = new io_projekt_cs.Uzytkownik();
        Koszyk kosz = new Koszyk();
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
            while (klucz != 0 && klucz != 1)
            {
                if (user.islogged)
                {
                    int id1 = klucz - 1;
                    kosz.id_pr.Add(id1);
                    string mark = b.get_marka(id1);
                    string mode = b.get_model(id1);
                    int ro = b.get_rok(id1);
                    int przeb = b.get_przebieg(id1);
                    int cen = b.get_cena(id1);
                    b.dodaj_do_koszyka(id1, mark, mode, ro, przeb, cen);
                    Console.WriteLine("Dodano przedmiot poprawnie, aby wyjsc wcisnij 0");
                    Console.WriteLine("Aby dodac kolejne przedmioty podaj ich numer");
                    klucz = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Musisz byc zalogowany");
                    Console.ReadKey();
                    klucz = 0;
                }

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
                Console.WriteLine("5. Pokaz produkty w koszyku");
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
            int[] idd = b.get_id_us(b.size_usera());
            for (int i = 1; i <= b.size_usera(); i++)
            {
                int k = i + 1;
                Console.Write(k + ". ");
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", idd[i-1], b.get_marka_us(idd[i-1]), b.get_model_us(idd[i - 1]), b.get_rok_us(idd[i - 1]), b.get_przebieg_us(idd[i - 1]), b.get_cena_us(idd[i - 1]));
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Aby wrocic kliknij 1");
            int klucz = Convert.ToInt32(Console.ReadLine());
            return klucz;
        }
        public int wyswietl_koszyk(Baza_danych b)
        {
            Console.Clear();
            for (int i = 1; i <= kosz.id_pr.Count; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine("id [{0}], marka [{1}], model [{2}], rok [{3}], przebieg [{4}km], cena [{5}zl]", kosz.id_pr[i - 1], b.get_marka_ko(kosz.id_pr[i - 1]), b.get_model_ko(kosz.id_pr[i - 1]), b.get_rok_ko(kosz.id_pr[i - 1]), b.get_przebieg_ko(kosz.id_pr[i - 1]), b.get_cena_ko(kosz.id_pr[i - 1]));
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Koszt przedmiotow = " + kosz.oblicz_koszt(b));
            Console.WriteLine("Prowizja = " + kosz.oblicz_prowizje());
            Console.WriteLine("Łaczny koszt = " + kosz.caly_koszt());
            Console.WriteLine("Aby wrocic kliknij 0");
            Console.WriteLine("Aby zaplacic kliknij 99");
            Console.WriteLine("Aby usunac przedmiot z koszyka podaj jego id");
            int klucz = Convert.ToInt32(Console.ReadLine());
            if(klucz==99)
            {
                klucz=zaplac(b);
            }
            else if(klucz!=0)
            {
                kosz.aktualizuj(klucz, b);
                b.usun_wybrane(klucz);
                kosz.id_pr.Remove(klucz);
                Console.WriteLine("Usunieto poprawnie");
                Console.ReadKey();
                wyswietl_koszyk(b);
            }
            return klucz;
        }
        public int zaplac(Baza_danych b)
        {
            Console.Clear();
            Console.WriteLine(" Cena : " + kosz.caly_koszt());
            Console.WriteLine("1. Zaplac paypalem");
            Console.WriteLine("2. Zaplac przelewem");
            int klucz = Convert.ToInt32(Console.ReadLine());
            if(klucz==1)
            {
                Console.WriteLine("Zaplacono paypalem");
                kosz.id_pr.Clear();
                kosz.zeruj();
                b.usun();
            }
            else if(klucz==2)
            {
                Console.WriteLine("Zaplacono przelewem");
                kosz.id_pr.Clear();
                kosz.zeruj();
                b.usun();
            }
            Console.ReadKey();
            klucz = 0;
            return klucz;
        }
    }
}
