using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turf_Management.Data;
using Turf_Management.Models;

namespace Turf_Management.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Cust_Index()
        {
            return View();
        }

        public async Task<IActionResult> Book_index(string S_location, int? pageNumber)
        {

            var joinedData = from t1 in _context.Turf_details
                             join t2 in _context.Booking on t1.T_id equals t2.T_id
                             join t3 in _context.customers on t2.C_id equals t3.C_id

                             select new B_details
                             {
                                 T_id = t1.T_id,
                                 T_location = t1.T_location,
                                 B_id = t2.B_id,
                                 B_from_time = t2.B_from_time,
                                 B_To_time = t2.B_To_time,
                                 B_booking_date = t2.B_booking_date,
                                 B_availability = t2.B_availability,
           
                             };

            int pageSize = 5;
            return View(await PaginatedList<B_details>.CreateAsync(joinedData.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public IActionResult Book()
        {
            var C_id = HttpContext.Session.GetInt32("C_id");

            List<Turf_details> cl1 = new List<Turf_details>();
            cl1 = _context.Turf_details.ToList();
            cl1.Insert(0, new Turf_details { T_id = 0, T_location = "--Select Location Name--" });
            ViewBag.message = cl1;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Book(Booking Boo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Booking.Add(Boo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Book_index));
            }
            return View(Boo);
        }

        public IActionResult C_feedback()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> C_feedback(Feedback fee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Feedback.Add(fee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(feedback));

            }
            return View(fee);
        }

        public IActionResult feedback()
          {
              int? shopId = HttpContext.Session.GetInt32("C_id");
          
              var details = from t1 in _context.Feedback
                            where t1.C_id == shopId
                            select t1;
              return View(details.ToList());
          }

    }
}
