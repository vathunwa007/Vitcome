using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace netcore.Models
{
    public class Techer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }
        public int Status { get; set; }
          
    }
    
}