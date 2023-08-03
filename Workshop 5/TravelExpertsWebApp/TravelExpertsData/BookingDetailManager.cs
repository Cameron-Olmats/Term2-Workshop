using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class BookingDetailManager
    {
        public static List<BookingDetail> GetBookingDetailByCustomer(int id, TravelExpertsContext db)
        {
            List<BookingDetail> bookingDetails = db.BookingDetails
                .Include(b => b.Booking)
                .Include(b => b.Fee)
                .Include(b => b.ProductSupplier.Product)
                .Include(b => b.Class)
                .Include(b => b.Region)
                .Where(b => b.Booking.CustomerId == id)
                .ToList();

            return bookingDetails;
        }
    }
}
