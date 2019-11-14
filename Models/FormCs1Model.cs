using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace netcore.Models
{
    public class FormCs1Model
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string idstudent { get; set; }
        public string sector { get; set; }
        public string title { get; set; }
        public string titleEng { get; set; }
        public string importance { get; set; } 
        public string objective { get; set; }
        public string reasoning { get; set; }
        public IFormFile timeimage { get; set; }
        public string scope { get; set; }
        public string studentid { get; set; }

    }
}
