using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace io_projekt_cs
{
    public class Baza_danych
    {
        //polaczenie
        MySqlConnection polaczenie = new MySqlConnection("server=sql.twp.home.pl; user=00092481_marek; password=haju04-pogon; database=00092481_marek;");
        MySqlCommand command;
        MySqlDataReader reader;
        string select = "";

        private static Baza_danych _oobiekt;

        //kontruktor musi byc prywatny lub protected
        //aby uniemożliwić utworzenie obiektu
        //za pomocą operatora new
        protected Baza_danych() { }

        //publiczna metoda statyczna za pomocą której
        //otzymamy referencję do obiektu
        public static Baza_danych utworzObiekt()
        {
            //sprawdzamy czy już utworzyliśmy instancję klasy
            if (_oobiekt == null)
            {
                //jeśli nie to ją tworzymy
                _oobiekt = new Baza_danych();
            }
            //zwracamy instancję obiektu zapisanego
            //w stacznym polu naszej klasy
            return _oobiekt;
        }

        public void nowy_user(string email, string haslo)
        {
            if (polaczenie.State == System.Data.ConnectionState.Closed)
                polaczenie.Open();
            select = "INSERT INTO `00092481_marek`.`user` (`email`, `haslo`) VALUES('" + email + "', '" + haslo + "'); ";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();
        }

        public int size()
        {
            if(polaczenie.State==System.Data.ConnectionState.Closed)
                polaczenie.Open();
            select = "SELECT id FROM Oferty";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            polaczenie.Close();
            return i;
        }
        public int size_usera()
        {
            polaczenie.Open();
            select = "SELECT id FROM oferty_usera";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            polaczenie.Close();
            return i;
        }

        public int size_koszyk()
        {
            polaczenie.Open();
            select = "SELECT id FROM Koszyk";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                i++;
            }
            polaczenie.Close();
            return i;
        }
        public int[] get_id(int size)
        {
            polaczenie.Open();
            select = "SELECT id FROM Oferty";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            int[] str = new int[size];
            while (reader.Read())
            {
                str[i] = Convert.ToInt32(reader[i]);
                i++;
            }
            polaczenie.Close();
            return str;
        }

        public string get_marka(int id)
        {
            polaczenie.Open();
            select = "SELECT marka FROM Oferty WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public string get_model(int id)
        {
            polaczenie.Open();
            select = "SELECT model FROM Oferty WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public int get_rok(int id)
        {
            polaczenie.Open();
            select = "SELECT rok FROM Oferty WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_przebieg(int id)
        {
            polaczenie.Open();
            select = "SELECT przebieg FROM Oferty WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_cena(int id)
        {
            polaczenie.Open();
            select = "SELECT cena FROM Oferty WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;

        }

        public void insert_aut(int id, string marka, string model, int rok, int przebieg, int cena)
        {

            polaczenie.Open();
            select = "INSERT INTO `00092481_marek`.`Oferty` (`id`, `marka`, `model`, `rok`, `przebieg`, `cena`) VALUES('" + id + "', '" + marka + "', '" + model + "', '" + rok + "', '" + przebieg + "', '" + cena + "'); ";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();
            polaczenie.Open();
            select = "INSERT INTO `00092481_marek`.`oferty_usera` (`id`, `marka`, `model`, `rok`, `przebieg`, `cena`) VALUES('" + id + "', '" + marka + "', '" + model + "', '" + rok + "', '" + przebieg + "', '" + cena + "'); ";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();
        }

        public int[] get_id_us(int size)
        {
            polaczenie.Open();
            select = "SELECT id FROM oferty_usera";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            int[] str = new int[size];
            while (reader.Read())
            {
                str[i] = Convert.ToInt32(reader[0]);
                i++;
            }
            polaczenie.Close();
            return str;
        }

        public string get_marka_us(int id)
        {
            polaczenie.Open();
            select = "SELECT marka FROM oferty_usera WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public string get_model_us(int id)
        {
            polaczenie.Open();
            select = "SELECT model FROM oferty_usera WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public int get_rok_us(int id)
        {
            polaczenie.Open();
            select = "SELECT rok FROM oferty_usera WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_przebieg_us(int id)
        {
            polaczenie.Open();
            select = "SELECT przebieg FROM oferty_usera WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_cena_us(int id)
        {
            polaczenie.Open();
            select = "SELECT cena FROM oferty_usera WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;

        }

        public void dodaj_do_koszyka(int id, string marka, string model, int rok, int przebieg, int cena)
        {
            polaczenie.Open();
            select = "INSERT INTO `00092481_marek`.`Koszyk` (`id`, `marka`, `model`, `rok`, `przebieg`, `cena`) VALUES('" + id + "', '" + marka + "', '" + model + "', '" + rok + "', '" + przebieg + "', '" + cena + "'); ";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();
        }
        public int get_cena_koszyk(int id)
        {
            polaczenie.Open();
            select = "SELECT cena FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;

        }
        public string get_marka_ko(int id)
        {
            polaczenie.Open();
            select = "SELECT marka FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public string get_model_ko(int id)
        {
            polaczenie.Open();
            select = "SELECT model FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            string str = reader[0].ToString();
            polaczenie.Close();
            return str;
        }

        public int get_rok_ko(int id)
        {
            polaczenie.Open();
            select = "SELECT rok FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_przebieg_ko(int id)
        {
            polaczenie.Open();
            select = "SELECT przebieg FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }

        public int get_cena_ko(int id)
        {
            polaczenie.Open();
            select = "SELECT cena FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;

        }
        public void usun()
        {
            polaczenie.Open();
            select = "DELETE FROM Koszyk";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();

        }
        public void usun_wybrane(int id)
        {
            polaczenie.Open();
            select = "DELETE FROM Koszyk WHERE id=" + id.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            polaczenie.Close();
        }

        public int get_id_ce(int cena)
        {

            polaczenie.Open();
            select = "SELECT id FROM Oferty WHERE cena=" + cena.ToString();
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();

            reader.Read();
            int str = Convert.ToInt32(reader[0]);
            polaczenie.Close();
            return str;
        }
        public void sortuj_wzgledem_ceny()
        {
            int leg = size();
            Console.Clear();
            polaczenie.Open();
            select = "SELECT * FROM Oferty ORDER BY cena";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.Write("id [{0}] ", reader["id"].ToString());
                Console.Write(" marka [{0}] ", reader["marka"].ToString());
                Console.Write(" model [{0}] ", reader["model"].ToString());
                Console.Write(" rocznik [{0}] ", reader["rok"].ToString());
                Console.Write(" przebieg [{0}] ", reader["przebieg"].ToString());
                Console.Write(" cena [{0}] ", reader["cena"].ToString());
                Console.WriteLine("");

            }
            polaczenie.Close();
        }
        public void szukaj(string name)
        {
            Console.Clear();
            polaczenie.Open();
            select = "SELECT * FROM Oferty WHERE marka LIKE " + "\"" + name + "\"";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                Console.Write("id [{0}] ", reader["id"].ToString());
                Console.Write(" marka [{0}] ", reader["marka"].ToString());
                Console.Write(" model [{0}] ", reader["model"].ToString());
                Console.Write(" rocznik [{0}] ", reader["rok"].ToString());
                Console.Write(" przebieg [{0}] ", reader["przebieg"].ToString());
                Console.Write(" cena [{0}] ", reader["cena"].ToString());
                Console.WriteLine("");
                i++;
            }
            if(i==0)
            {
                Console.Clear();
                Console.WriteLine("W bazie nie ma takiego auta!");
                Console.ReadKey();
            }
            polaczenie.Close();
            Console.ReadKey();
        }

        public bool czy_zalogowano(string em,string has)
        {
            polaczenie.Open();
            select = "SELECT haslo FROM user WHERE email LIKE " + "\"" + em+ "\"";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            reader.Read();
            if (has == reader["haslo"].ToString())
            {
                polaczenie.Close();
                return true;
            }
            else
            {

                polaczenie.Close();
                return false;
            }
               
        }
    }
}
