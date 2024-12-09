using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turf_Management.Data;
using Turf_Management.Models;

namespace Turf_Management.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Admin_Index()
        {
            return View();
        }
        public IActionResult Turf_Reg()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Turf_Reg(Turf_details turf)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Turf_details.Add(turf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;

                }
                return RedirectToAction(nameof(Turf_index));
            }
            return View(turf);
        }
        public async Task<IActionResult> Turf_index()
        {
            return _context.Turf_details != null ?
            View(await _context.Turf_details.ToListAsync()) :
            Problem("Entity set 'ApplicationDbContext.Turf_details' is null.");
        }
        public async Task<IActionResult> Cust_index()
        {
            return _context.customers != null ?
            View(await _context.customers.ToListAsync()) :
            Problem("Entity set 'ApplicationDbContext.customers' is null.");
        }

        
            public async Task<IActionResult> Pay_index(string S_location, int? pageNumber)
            {
               
                var joinedData = from t1 in _context.Turf_details
                                 join t2 in _context.Booking on t1.T_id equals t2.T_id
                                 join t3 in _context.customers on t2.C_id equals t3.C_id
                                
                                 select new B_details
                                 {
                                    T_id =t1.T_id,
                                    T_location =t1.T_location,
                                    B_id      =t2.B_id,
                                    B_from_time = t2.B_from_time,
                                    B_To_time =t2.B_To_time,
                                    B_booking_date=t2.B_booking_date,
                                    B_acc_details=t2.B_acc_details,
                                    B_payment =t2.B_payment,
                                    B_availability=t2.B_availability,
                                    C_id =t3.C_id,
                                    C_name=t3.C_name,

                                 };

                int pageSize = 5;
                return View(await PaginatedList<B_details>.CreateAsync(joinedData.AsNoTracking(), pageNumber ?? 1, pageSize));
            }

        public async Task<IActionResult> feedback(int? pageNumber)
        {

            var joinedData = from t1 in _context.customers
                             join t2 in _context.Feedback on t1.C_id equals t2.C_id
                             select new Models.Register
                             {
                                 C_id = t1.C_id,
                                 C_name = t1.C_name,
                                 F_id = t2.F_id,
                                 F_feedback = t2.F_feedback,
                       
                             };

            int pageSize = 5;
            return View(await PaginatedList<Models.Register>.CreateAsync(joinedData.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

    }
}
