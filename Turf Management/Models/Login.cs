using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Login
    {
        [Key]
        public int L_id { get; set; }
        public int C_id { get; set; }
        //[RegularExpression(@" ^[a-zA-Z0-9_.±]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "INVALID EMAIL")]
        [Required(ErrorMessage = "Email is required")]
        public string L_email {  get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string L_password { get; set; }
        public string L_type { get; set; }
    }
}
