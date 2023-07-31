using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TravelExpertsData;
namespace TravelExpertsMVC.Controllers
{
    public class CustomerController : Controller
    {
        TravelExpertsContext _context { get; set; }

        public CustomerController(TravelExpertsContext context)
        {
            _context = context;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        // for viewing personal information:
        // GET: CustomerController/Details/5
        public ActionResult Details()
        {
            int id = Convert.ToInt32(User.FindFirst("Id").Value); // get user id from the Claim

            // use that id to find the customer
            Customer currentCust = CustomerManager.GetCustomerById(id, _context);
            if (currentCust != null)
            {
                return View(currentCust);
            }
            return RedirectToAction("Logout", "Customer");
            // right now it just logs you out if it can't find a customer that matches but this should never happen
            // since you need to be logged in in order to see the details link and if you're logged in you are
            // an existing customer.
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Login(string returnUrl)
        {
            if (returnUrl != null)
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(string returnUrl, Customer customer)
        {
            Customer? cust = CustomerManager.Authenticate(customer.CustUsername, customer.CustPassword, _context);

            if (cust == null)
            {
                return View();
            }

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, cust.CustUsername),
                new Claim("FullName", cust.CustFirstName + " " + cust.CustLastName),
                new Claim("Id", cust.CustomerId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

            if (TempData["ReturnUrl"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home"); //I want this to be the return url but I don't know how
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home"); // after logout - return to home page of website
        }
    }
}
