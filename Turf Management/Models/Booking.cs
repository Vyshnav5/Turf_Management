using System;
using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Booking
    {
        [Key]
        public int B_id { get; set; }
        public int T_id { get; set; }
        public int C_id { get; set; }
        [Required(ErrorMessage = "Booking time is required")]
        public string B_from_time { get; set; }
        [Required(ErrorMessage = "Booking time is required")]
        public string B_To_time { get; set; }
        [Required(ErrorMessage = "Booking date is required")]
        public string B_booking_date { get; set; }

        [Required(ErrorMessage = "Payment is required")]
        public string B_payment {  get; set; }

        [Required(ErrorMessage = "Bank details or Card details is required")]
        public string B_acc_details { get; set; }
        public string B_availability { get; set; }
    }
}
