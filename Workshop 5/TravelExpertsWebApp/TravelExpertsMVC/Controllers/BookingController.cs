﻿/*
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

        //public IActionResult Index()
        //{
            
        //    List<Booking> bookings = new List<Booking>();
        //    try
        //    {
        //        int id = Convert.ToInt32(User.FindFirst("Id").Value);
        //        bookings = BookingManager.GetBookingsByCustomerId(id, _context);
        //    }
        //    catch
        //    {
        //        TempData["IsError"] = true;
        //        TempData["Message"] = "Could not access your purchases. Please log in and try again";
        //    }
        //    return View(bookings);
        //}

        public IActionResult Index()
        {
            try
            {
                int id = Convert.ToInt32(User.FindFirst("Id").Value);
                List<BookingDetail> info = BookingDetailManager.GetBookingDetailsByCustomer(id, _context);

                return View(info);

            }
            catch 
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Could not display Booking Details. Please try again later";
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                BookingDetail bookingDetail = BookingDetailManager.GetBookingDetailById(id, _context);
                //if (bookingDetail.BookingId != null) // get the package base price associated with the booking and add it to view bag
                //{
                //    int bookingId = (int)bookingDetail.BookingId;
                //    Booking booking = BookingManager.GetBookingById(bookingId, _context);
                //    try
                //    {
                //        ViewBag.PackageBasePrice = booking.Package.PkgBasePrice;
                //    }
                //    catch (System.NullReferenceException ex)
                //    {
                //        ViewBag.PackageBasePrice = null;
                //    }
                //}
                //else // if it can't get the base price of the package, assign null.
                //{
                //    ViewBag.PackageBasePrice = null;
                //}
                return View(bookingDetail);
            }
            catch
            {
                TempData["IsError"] = true;
                TempData["Message"] = "Could not display Booking price breakdown. Please try again later";
                return RedirectToAction("Index", "Booking");
            }
        }
    }
}
