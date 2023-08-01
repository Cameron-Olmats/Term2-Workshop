using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

[Index("AgentId", Name = "EmployeesCustomers")]
public partial class Customer
{
    [Key]
	[Display(Name = "ID")]
	public int CustomerId { get; set; }

    [StringLength(25)]
	[Display(Name = "First Name")]
	public string CustFirstName { get; set; } = null!;

    [StringLength(25)]
	[Display(Name = "Last Name")]
	public string CustLastName { get; set; } = null!;

    [StringLength(75)]
	[Display(Name = "Street Address")]
	public string CustAddress { get; set; } = null!;

    [StringLength(50)]
    [Display(Name = "City")]
    public string CustCity { get; set; } = null!;

    [StringLength(2)]
	[Display(Name = "Province")]
	public string CustProv { get; set; } = null!;

    [StringLength(7)]
	[Display(Name = "Postal Code")]
	public string CustPostal { get; set; } = null!;

    [StringLength(25)]
	[Display(Name = "Country")]
	public string? CustCountry { get; set; }

    [StringLength(20)]
	[Display(Name = "Home Phone")]
	public string? CustHomePhone { get; set; }

    [StringLength(20)]
	[Display(Name = "Bus Phone")]
	public string CustBusPhone { get; set; } = null!;

    [StringLength(50)]
	[Display(Name = "Email")]
	public string CustEmail { get; set; } = null!;

    [StringLength(30)]
    [Display(Name = "Username")]
    public string CustUsername { get; set; } = null!;

    [StringLength(30)]
	[Display(Name = "Password")]
	public string CustPassword { get; set; } = null!;

    [StringLength(30)]
    [Display(Name = "Confirm Password")]
    [Compare("CustPassword")]
    public string CustConfirmPassword { get; set; } = null!;

    public int? AgentId { get; set; }

    [ForeignKey("AgentId")]
    [InverseProperty("Customers")]
    public virtual Agent? Agent { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("Customer")]
    public virtual ICollection<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

    [InverseProperty("Customer")]
    public virtual ICollection<CustomersReward> CustomersRewards { get; set; } = new List<CustomersReward>();
}
