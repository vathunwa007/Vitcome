using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Models
{
    public class Register
    {
        [Key]
        [Required]
        [Display(Name = "idstudent")]
        
        public Double idstudent { get; set; }

        public string password { get; set; }

        public string name { get; set; }

        public string suranme { get; set; }

        public int year { get; set; }

        public string email { get; set; }

        public string telnumber { get; set; }
    }
}