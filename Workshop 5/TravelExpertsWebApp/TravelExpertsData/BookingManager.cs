using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class BookingManager
    {
        public static List<Booking> GetBookingsByCustomerId(int id, TravelExpertsContext db)
        {
            List<Booking> bookings = db.Bookings.Where(b => b.CustomerId == id).ToList();
            return bookings;
        }

        /// <summary>
        /// Finds a booking and includes package. Intended for /Booking/Details
        /// </summary>
        /// <param name="id">Id of the booking that you want</param>
        /// <param name="db">database context</param>
        /// <returns>Booking with package included</returns>
        public static Booking GetBookingById(int id, TravelExpertsContext db)
        {
            Booking booking = db.Bookings.Include(b => b.Package).Where(b=> b.BookingId == id).First();
            return booking;
        }


        //public static Fee GetBookingFee(string id, TravelExpertsContext db)
        //{
        //    Fee fee = db.Fees.Where(f => f.FeeId == id).First;
        //    return ;

        //}
    }
}
