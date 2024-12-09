using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Register
    {
        public int L_id { get; set; }
        [Required(ErrorMessage = "Email is required")]
        //[RegularExpression(@" ^[a-zA-Z0-9_.±]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "INVALID EMAIL")]
        public string L_email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string L_password { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters")]
        public string C_name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number format. It should be 10 digits.")]
        public string C_ph { get; set; }
        
        public string L_type { get; set; }
        public int F_id { get; set; }
        public int C_id { get; set; }
        public string F_feedback { get; set; }
    }
}
