using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Turf_Management.Models
{
    public class Feedback
    {
        [Key]
        public int F_id { get; set; }
        public int C_id { get; set; }
        public string F_feedback { get; set; }
    }
}
