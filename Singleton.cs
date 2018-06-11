using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_projekt_cs
{
    public class Singleton
    {
        //tutaj przechowujemy utworzony ewentualnie obiekt
        private static Singleton _obiekt;

        //kontruktor musi byc prywatny lub protected
        //aby uniemożliwić utworzenie obiektu
        //za pomocą operatora new
        protected Singleton() { }

        //publiczna metoda statyczna za pomocą której
        //otzymamy referencję do obiektu
        public static Singleton utworzObiekt()
        {
            //sprawdzamy czy już utworzyliśmy instancję klasy
            if (_obiekt == null)
            {
                //jeśli nie to ją tworzymy
                _obiekt = new Singleton();
            }
            //zwracamy instancję obiektu zapisanego
            //w stacznym polu naszej klasy
            return _obiekt;
        }
    }
}
