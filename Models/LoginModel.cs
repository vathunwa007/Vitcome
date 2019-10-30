using System.ComponentModel.DataAnnotations;

namespace netcore.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="กรุณาใส่รหัสนักศึกษาให้ครบถ้วน")]
        [MaxLength(10, ErrorMessage = "Id length can't be more than 10.")]
        public string idstudent {get;set;}
        [Required(ErrorMessage = "กรุณาใส่รหัสผ่านให้ครบถ้วน")]
        [DataType(DataType.Password)]
        public string password {get;set;}
        [Required]
        public bool checkteacher { get; set; }


    }
}