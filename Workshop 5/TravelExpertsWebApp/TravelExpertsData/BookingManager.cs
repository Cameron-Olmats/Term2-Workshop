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

        //public static Fee GetBookingFee(string id, TravelExpertsContext db)
        //{
        //    Fee fee = db.Fees.Where(f => f.FeeId == id).First;
        //    return ;

        //}
    }
}
