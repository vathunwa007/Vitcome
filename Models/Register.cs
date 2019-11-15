using System.ComponentModel.DataAnnotations;

namespace netcore.Models
{
    public class Register
    {
        internal readonly string password;

        [Key]
        [Required (ErrorMessage="กรุณาป้อนข้อมูลให้ครบ")]
        public double Idstudent {get; set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string Password {get; set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string Name  {get; set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string Lastname {get; set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public int Year {get;set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string Email {get; set;}
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public double Telephone {get;set;}

    }
}