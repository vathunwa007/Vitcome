using System;
using MySql.Data.MySqlClient;

namespace Netcore.Performance
{
    public class Condb : IDisposable
    {
        public MySqlConnection Connection;

        public Condb(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}