using Microsoft.AspNetCore.Mvc;
using Turf_Management.Data;
using Turf_Management.Models;

namespace Turf_Management.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Log_Index()
        {
            return View();
        }

        public IActionResult Log(Login r)
        {
            var filtered = from l in _context.Login
                           where l.L_email == r.L_email && l.L_password == r.L_password
                           select l;

            foreach (var p in filtered)
            {
                string type = p.L_type;

                if (type == "Customer")
                {
                   
                    HttpContext.Session.SetInt32("C_id", p.C_id);
                    return new RedirectResult(url: "/Customer/Cust_Index", permanent: true, preserveMethod: true);
                }
                else if (type == "Admin")
                {
                    return new RedirectResult(url: "/Admin/Admin_Index", permanent: true, preserveMethod: true);
                }

            }

            return Ok();
        }

        public IActionResult Cust_Reg()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cust_Reg(Customer mov, Login mo)
        {

            if (ModelState.IsValid)
            {



                _context.customers.Add(mov);
                await _context.SaveChangesAsync();

                var shopId = mov.C_id;

                mo.C_id = shopId;

                _context.Login.Add(mo);
                await _context.SaveChangesAsync();



                return RedirectToAction(nameof(Log_Index));



            }
            else
            {
                return View();
            }

        }

    }
}
