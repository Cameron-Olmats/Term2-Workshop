using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelExpertsData;

namespace TravelExpertsMVC.Models
{
    public class BookingDisplayModel
    {
        public int BookingId { get; set; }

        [StringLength(50)]
        public string? BookingNo { get; set; }

        public DateTime? BookingDate { get; set; }

        public double? TravelerCount { get; set; }

        public string? TripTypeName { get; set; }

        public Fee? Fee { get; set; }

        public Product? Product { get; set; }

        public Supplier? Supplier { get; set; }
    }
}
