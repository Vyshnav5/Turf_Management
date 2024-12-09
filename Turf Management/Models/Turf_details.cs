using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Turf_details
    {
        [Key]
        public int T_id {  get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string T_location {  get; set; }
        [Required(ErrorMessage = "Phone Number is required")]
        public string T_ph {  get; set; }
        [Required(ErrorMessage = "Time is required")]
        public string T_from_timing { get; set; }
        [Required(ErrorMessage = "Time is required")]
        public string T_to_timing { get; set; }

    }
}
