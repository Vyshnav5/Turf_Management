using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Customer
    {
        [Key]
        public int C_id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters")]
        public string C_name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number format. It should be 10 digits.")]
        public string C_ph { get; set; }
    }
}
