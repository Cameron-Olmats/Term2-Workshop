﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TravelExpertsData;

namespace TravelExpertsData
{
    public partial class Package
    {
        public Package()
        {
            Bookings = new HashSet<Booking>();
            
        }

        [Key]
        public int PackageId { get; set; }
        [StringLength(50)]
        public string PkgName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? PkgStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PkgEndDate { get; set; }
        [StringLength(50)]
        public string? PkgDesc { get; set; }
        [Column(TypeName = "money")]
        public decimal PkgBasePrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? PkgAgencyCommission { get; set; }

        [InverseProperty("Package")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty("Package")]
        public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; }
    }
}
