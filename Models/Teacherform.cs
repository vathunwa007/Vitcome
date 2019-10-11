using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace netcore.Models
{
    public class Teacherform
    {

        public Addfromteacher from { get; set; }
        public List<Techer> ts{get; set;}
     }
}
