using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSakilaCore.Models
{
    public class register
    {
       

        public string idstudent { get; set; }

        public string password { get; set; }

        public string name { get; set; }

        public string suranme { get; set; }

        public string year { get; set; }

        public string email { get; set; }

        public string telnumber { get; set; }
    }
}