/*
 * Controller for bookings. For displaying bookings that a customer has purchased.
 * 
 * Author: Cameron Olmatws
 * Date: 2023-08-02
 */

using Microsoft.AspNetCore.Mvc;
using TravelExpertsData;
using TravelExpertsMVC.Models;

namespace TravelExpertsMVC.Controllers
{
    public class BookingController : Controller
    {
        private TravelExpertsContext _context;

        public BookingController(TravelExpertsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            List<Booking> bookings = new List<Booking>();
            try
            {
                int id = Convert.ToInt32(User.FindFirst("Id").Value);
                bookings = BookingManager.GetBookingsByCustomerId(id, _context);
            }
            catch
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Could not access your purchases. Please log in and try again";
            }
            return View(bookings);
        }

        public IActionResult Details()
        {
            List<Booking> bookings = new List<Booking>();

            int id = Convert.ToInt32(User.FindFirst("Id").Value);
            bookings = BookingManager.GetBookingsByCustomerId(id, _context);

            BookingDisplayModel bookingDisplay = new BookingDisplayModel();

            foreach (Booking b in bookings)
            {
                bookingDisplay.BookingId = b.BookingId;
                bookingDisplay.BookingNo = b.BookingNo;
                bookingDisplay.BookingDate = b.BookingDate;
                bookingDisplay.TravelerCount = b.TravelerCount;
                //bookingDisplay.TripTypeName = 

                //bookingDisplay.TripTypeName = b.TripTypeName;
                
            }
            

            return View(bookingDisplay);
        }
    }
}
