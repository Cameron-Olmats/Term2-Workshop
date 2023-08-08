using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TravelExpertsData;
/// Displays packages using TravelExperts Data
/// authors: Dreesha, Cam O.
/// Date: July/Aug 2023
namespace TravelExpertsData
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();

        }

        [Key]
        public HashSet<Booking> Bookings { get; set; }
        public object PkgName { get; set; } = null;
        public object PackageId { get; set; }
        public object PkgBasePrice { get; set; }
        public object PkgAgencyCommission { get; set; }
        public object PkgStartDate { get; set; }
        public object PkgEndDate { get; set; }
        public object PkgDesc { get; set; }
        public object PackagesProductsSuppliers { get; internal set; }

        
            [InverseProperty("Package")]
            public virtual ICollection<Booking> Bookings { get; set; }
            [InverseProperty("Package")]
            public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set;}
        }
    }

