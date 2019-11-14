using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace netcore.Models
{
    public class showdata
    {
        public string name { get; set; }
        public string title { get; set; }
        public string timeimage { get; set; }
        
        public string comment { get; set; }
    }
}
