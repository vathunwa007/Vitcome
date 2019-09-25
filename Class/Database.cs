using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace netcore.Class
{
    public class Database
    {
        public MySqlConnection connection;
        private String conString = "server=localhost;username=root;password=12345678;database=Vitcome"
        private MySqlConnection myConnection;

        public Database()
        {
             connection = new MySqlConnection(conString);
            connection.Open();

        }

        public DataTable GetData(String _sqlComand)
        {
            MySqlCommand command = new MySqlCommand(_sqlComand, myConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void ExcuteQuery(String _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand("", MySqlConnection);
            command.CommandText = _sqlCommand;
            command.CommandText = CommandType.Text;
            command.Connection = MySqlConnection;
            command.ExecuteNonQuery();





        }


    }
}
