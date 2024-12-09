using Microsoft.EntityFrameworkCore;
using Turf_Management.Models;

namespace Turf_Management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Turf_details> Turf_details { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
    }
}
