using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace netcore.Models
{
    public class Showtecher
    {
        public string ConnectionString { get; set; }

        public Showtecher(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Techer> GetAllTecher()
        {
            List<Techer> list = new List<Techer>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM techer", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Techer()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Skill = reader.GetString("Skill"),
                            Status = reader.GetInt32("Status")
                        });
                    }
                }
            }

            return list;
        }

        internal class Models
        {
        }
    }
}