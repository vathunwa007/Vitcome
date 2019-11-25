using System.ComponentModel.DataAnnotations;

namespace netcore.Models
{
    public class Registerteacher
    {
        [Key]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public double idteacher { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string password { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string name { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string skill { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string image { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public string email { get; set; }
        [Required(ErrorMessage = "กรุณาป้อนข้อมูลให้ครบ")]
        public double telephone { get; set; }

    }
}