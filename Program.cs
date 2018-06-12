using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemMan.utworzObiekt();
            Baza_danych.utworzObiekt();
            int klucz=0;
            while (true)
            {
                
                if (klucz == 1 || klucz==0)
                {
                    klucz= SystemMan.utworzObiekt().mainpanel();
                    if (klucz == 5)
                    {
                        klucz = SystemMan.utworzObiekt().zarejestruj(Baza_danych.utworzObiekt());
                    }
                    if (klucz == 6)
                        klucz = SystemMan.utworzObiekt().zaloguj(Baza_danych.utworzObiekt());
                }
                if (klucz == 2)
                {
                    klucz= SystemMan.utworzObiekt().przegladaj(Baza_danych.utworzObiekt());
                }
                if (klucz == 3)
                {
                    klucz= SystemMan.utworzObiekt().mojekonto();
                    if (klucz == 5)
                        klucz = SystemMan.utworzObiekt().wyswiel_ogloszenia(Baza_danych.utworzObiekt());
                }
                if (klucz == 4)
                {
                    klucz= SystemMan.utworzObiekt().koszyk();
                    if (klucz == 5)
                    {
                        klucz = SystemMan.utworzObiekt().wyswietl_koszyk(Baza_danych.utworzObiekt());
                    }
                }
                if (klucz == 9)
                {
                    Console.Clear();
                    Console.WriteLine("Napisz wiadomosc do pomocy: ");
                    Console.ReadLine();
                    Console.WriteLine("Wiadomosc wyslana popawnie");
                    Console.ReadKey();
                    klucz = 1;
                }
            }

            Console.ReadKey();
        }
    }
}
