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
            int id = Convert.ToInt32(User.FindFirst("Id").Value);
            List<BookingDetail> info = BookingDetailManager.GetBookingDetailByCustomer(id, _context);
            
            return View(info);
            //List<Booking> bookings = new List<Booking>();

            //int id = Convert.ToInt32(User.FindFirst("Id").Value);
            //bookings = BookingManager.GetBookingsByCustomerId(id, _context);

           
            //List<BookingDisplayModel> list = new List<BookingDisplayModel>();
            //foreach (Booking b in bookings)
            //{
            //    BookingDisplayModel bookingDisplay = new BookingDisplayModel
            //    {
            //        BookingId = b.BookingId,
            //        BookingNo = b.BookingNo,
            //        BookingDate = b.BookingDate,
            //        TravelerCount = b.TravelerCount
                    
            //    };


            //    //bookingDisplay.TripTypeName = 

            //    //bookingDisplay.TripTypeName = b.TripTypeName;
            //    list.Add(bookingDisplay);
            //}
            

            //return View(list);
        }
    }
}
