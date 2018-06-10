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
        MySqlConnection polaczenie =  new MySqlConnection("server=sql.twp.home.pl; user=00092481_marek; password=haju04-pogon; database=00092481_marek;");
        MySqlCommand command;
        MySqlDataReader reader;
        string select = "";

        //public void polacz()
        //{

        //    if (polaczenie.State == System.Data.ConnectionState.Open)
               
        //    else
        //        polaczenie.Close();
        //}

        public int size()
        {
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
        public int[] get_id(int size)
        {
            polaczenie.Open();
            select = "SELECT id FROM Oferty";
            command = new MySqlCommand(select, polaczenie);
            reader = command.ExecuteReader();
            int i = 0;
            int[] str=new int[size];
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
            select = "SELECT marka FROM Oferty WHERE id="+id.ToString();
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

    }
}
