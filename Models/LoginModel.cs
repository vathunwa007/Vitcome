using System.ComponentModel.DataAnnotations;

namespace netcore.Models
{
    public class LoginModel
    {
        [Required]
        public string idstudent {get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string password {get;set;}
        [Display(Name = "remember")]
        public bool remember { get; set; }


    }
}