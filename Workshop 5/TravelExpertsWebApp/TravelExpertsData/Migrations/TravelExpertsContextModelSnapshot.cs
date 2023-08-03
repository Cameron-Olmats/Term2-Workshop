﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelExpertsData;

#nullable disable

namespace TravelExpertsData.Migrations
{
    [DbContext(typeof(TravelExpertsContext))]
    partial class TravelExpertsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TravelExpertsData.Affiliation", b =>
                {
                    b.Property<string>("AffilitationId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AffDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AffName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AffilitationId")
                        .HasName("aaaaaAffiliations_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("AffilitationId"), false);

                    b.ToTable("Affiliations");
                });

            modelBuilder.Entity("TravelExpertsData.Agency", b =>
                {
                    b.Property<int>("AgencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgencyId"));

                    b.Property<string>("AgncyAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyCity")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyCountry")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyFax")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyPhone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyPostal")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgncyProv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AgencyId");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("TravelExpertsData.Agent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AgentId"));

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int");

                    b.Property<string>("AgtBusPhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AgtEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AgtFirstName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AgtLastName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AgtMiddleInitial")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("AgtPosition")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AgentId");

                    b.HasIndex("AgencyId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("TravelExpertsData.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime");

                    b.Property<string>("BookingNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<double?>("TravelerCount")
                        .HasColumnType("float");

                    b.Property<string>("TripTypeId")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("BookingId")
                        .HasName("aaaaaBookings_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("BookingId"), false);

                    b.HasIndex(new[] { "CustomerId" }, "BookingsCustomerId");

                    b.HasIndex(new[] { "CustomerId" }, "CustomersBookings");

                    b.HasIndex(new[] { "PackageId" }, "PackageId");

                    b.HasIndex(new[] { "PackageId" }, "PackagesBookings");

                    b.HasIndex(new[] { "TripTypeId" }, "TripTypesBookings");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TravelExpertsData.BookingDetail", b =>
                {
                    b.Property<int>("BookingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingDetailId"));

                    b.Property<decimal?>("AgencyCommission")
                        .HasColumnType("money");

                    b.Property<decimal?>("BasePrice")
                        .HasColumnType("money");

                    b.Property<int?>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("ClassId")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Destination")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FeeId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double?>("ItineraryNo")
                        .HasColumnType("float");

                    b.Property<int?>("ProductSupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("RegionId")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime?>("TripEnd")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("TripStart")
                        .HasColumnType("datetime");

                    b.HasKey("BookingDetailId")
                        .HasName("aaaaaBookingDetails_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("BookingDetailId"), false);

                    b.HasIndex(new[] { "FeeId" }, "Agency Fee Code");

                    b.HasIndex(new[] { "BookingId" }, "BookingId");

                    b.HasIndex(new[] { "BookingId" }, "BookingsBookingDetails");

                    b.HasIndex(new[] { "ClassId" }, "ClassesBookingDetails");

                    b.HasIndex(new[] { "RegionId" }, "Dest ID");

                    b.HasIndex(new[] { "RegionId" }, "DestinationsBookingDetails");

                    b.HasIndex(new[] { "FeeId" }, "FeesBookingDetails");

                    b.HasIndex(new[] { "ProductSupplierId" }, "ProductSupplierId");

                    b.HasIndex(new[] { "ProductSupplierId" }, "Products_SuppliersBookingDetails");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("TravelExpertsData.Class", b =>
                {
                    b.Property<string>("ClassId")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("ClassDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ClassId")
                        .HasName("aaaaaClasses_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ClassId"), false);

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("TravelExpertsData.CreditCard", b =>
                {
                    b.Property<int>("CreditCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CreditCardId"));

                    b.Property<DateTime>("Ccexpiry")
                        .HasColumnType("datetime")
                        .HasColumnName("CCExpiry");

                    b.Property<string>("Ccname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CCName");

                    b.Property<string>("Ccnumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CCNumber");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CreditCardId")
                        .HasName("aaaaaCreditCards_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CreditCardId"), false);

                    b.HasIndex(new[] { "CustomerId" }, "CustomersCreditCards");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("TravelExpertsData.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("CustAddress")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("CustBusPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CustCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustCountry")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CustEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustFirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CustHomePhone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CustLastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CustPassword")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CustPostal")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("CustProv")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CustUsername")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CustomerId")
                        .HasName("aaaaaCustomers_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CustomerId"), false);

                    b.HasIndex(new[] { "AgentId" }, "EmployeesCustomers");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TravelExpertsData.CustomersReward", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("RewardId")
                        .HasColumnType("int");

                    b.Property<string>("RwdNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CustomerId", "RewardId")
                        .HasName("aaaaaCustomers_Rewards_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("CustomerId", "RewardId"), false);

                    b.HasIndex(new[] { "CustomerId" }, "CustomersCustomers_Rewards");

                    b.HasIndex(new[] { "RewardId" }, "RewardsCustomers_Rewards");

                    b.ToTable("Customers_Rewards");
                });

            modelBuilder.Entity("TravelExpertsData.Employee", b =>
                {
                    b.Property<string>("EmpBusPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmpEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmpFirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmpLastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("EmpMiddleInitial")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("EmpPosition")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TravelExpertsData.Fee", b =>
                {
                    b.Property<string>("FeeId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("FeeAmt")
                        .HasColumnType("money");

                    b.Property<string>("FeeDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FeeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FeeId")
                        .HasName("aaaaaFees_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("FeeId"), false);

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("TravelExpertsData.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageId"));

                    b.Property<decimal?>("PkgAgencyCommission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("((0))");

                    b.Property<decimal>("PkgBasePrice")
                        .HasColumnType("money");

                    b.Property<string>("PkgDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("PkgEndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PkgName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("PkgStartDate")
                        .HasColumnType("datetime");

                    b.HasKey("PackageId")
                        .HasName("aaaaaPackages_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("PackageId"), false);

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("TravelExpertsData.PackagesProductsSupplier", b =>
                {
                    b.Property<int>("PackageProductSupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageProductSupplierId"));

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductSupplierId")
                        .HasColumnType("int");

                    b.HasKey("PackageProductSupplierId")
                        .HasName("PK__Packages__53E8ED9946414817");

                    b.HasIndex(new[] { "PackageId" }, "PackagesPackages_Products_Suppliers");

                    b.HasIndex(new[] { "ProductSupplierId" }, "ProductSupplierId");

                    b.HasIndex(new[] { "ProductSupplierId" }, "Products_SuppliersPackages_Products_Suppliers");

                    b.HasIndex(new[] { "PackageId", "ProductSupplierId" }, "UQ__Packages__29CA8E958A70DA4C")
                        .IsUnique();

                    b.ToTable("Packages_Products_Suppliers");
                });

            modelBuilder.Entity("TravelExpertsData.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProdName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductId")
                        .HasName("aaaaaProducts_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ProductId"), false);

                    b.HasIndex(new[] { "ProductId" }, "ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TravelExpertsData.ProductsSupplier", b =>
                {
                    b.Property<int>("ProductSupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductSupplierId"));

                    b.Property<int?>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductSupplierId")
                        .HasName("aaaaaProducts_Suppliers_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("ProductSupplierId"), false);

                    b.HasIndex(new[] { "SupplierId" }, "Product Supplier ID");

                    b.HasIndex(new[] { "ProductId" }, "ProductId");

                    b.HasIndex(new[] { "ProductSupplierId" }, "ProductSupplierId");

                    b.HasIndex(new[] { "ProductId" }, "ProductsProducts_Suppliers1");

                    b.HasIndex(new[] { "SupplierId" }, "SuppliersProducts_Suppliers1");

                    b.ToTable("Products_Suppliers");
                });

            modelBuilder.Entity("TravelExpertsData.Region", b =>
                {
                    b.Property<string>("RegionId")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("RegionName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("RegionId")
                        .HasName("aaaaaRegions_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("RegionId"), false);

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("TravelExpertsData.Reward", b =>
                {
                    b.Property<int>("RewardId")
                        .HasColumnType("int");

                    b.Property<string>("RwdDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RwdName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RewardId")
                        .HasName("aaaaaRewards_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("RewardId"), false);

                    b.ToTable("Rewards");
                });

            modelBuilder.Entity("TravelExpertsData.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("SupName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("SupplierId")
                        .HasName("aaaaaSuppliers_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("SupplierId"), false);

                    b.HasIndex(new[] { "SupplierId" }, "SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("TravelExpertsData.SupplierContact", b =>
                {
                    b.Property<int>("SupplierContactId")
                        .HasColumnType("int");

                    b.Property<string>("AffiliationId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SupConAddress")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConBusPhone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SupConCity")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConCompany")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConCountry")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConEmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConFax")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SupConFirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SupConLastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SupConPostal")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConProv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SupConUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("SupConURL");

                    b.Property<int?>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("SupplierContactId")
                        .HasName("aaaaaSupplierContacts_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("SupplierContactId"), false);

                    b.HasIndex(new[] { "AffiliationId" }, "AffiliationsSupCon");

                    b.HasIndex(new[] { "SupplierId" }, "SuppliersSupCon");

                    b.ToTable("SupplierContacts");
                });

            modelBuilder.Entity("TravelExpertsData.TripType", b =>
                {
                    b.Property<string>("TripTypeId")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Ttname")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("TTName");

                    b.HasKey("TripTypeId")
                        .HasName("aaaaaTripTypes_PK");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("TripTypeId"), false);

                    b.ToTable("TripTypes");
                });

            modelBuilder.Entity("TravelExpertsData.Agent", b =>
                {
                    b.HasOne("TravelExpertsData.Agency", "Agency")
                        .WithMany("Agents")
                        .HasForeignKey("AgencyId")
                        .HasConstraintName("FK_Agents_Agencies");

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("TravelExpertsData.Booking", b =>
                {
                    b.HasOne("TravelExpertsData.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("Bookings_FK00");

                    b.HasOne("TravelExpertsData.Package", "Package")
                        .WithMany("Bookings")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("Bookings_FK01");

                    b.HasOne("TravelExpertsData.TripType", "TripType")
                        .WithMany("Bookings")
                        .HasForeignKey("TripTypeId")
                        .HasConstraintName("Bookings_FK02");

                    b.Navigation("Customer");

                    b.Navigation("Package");

                    b.Navigation("TripType");
                });

            modelBuilder.Entity("TravelExpertsData.BookingDetail", b =>
                {
                    b.HasOne("TravelExpertsData.Booking", "Booking")
                        .WithMany("BookingDetails")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK_BookingDetails_Bookings");

                    b.HasOne("TravelExpertsData.Class", "Class")
                        .WithMany("BookingDetails")
                        .HasForeignKey("ClassId")
                        .HasConstraintName("FK_BookingDetails_Classes");

                    b.HasOne("TravelExpertsData.Fee", "Fee")
                        .WithMany("BookingDetails")
                        .HasForeignKey("FeeId")
                        .HasConstraintName("FK_BookingDetails_Fees");

                    b.HasOne("TravelExpertsData.ProductsSupplier", "ProductSupplier")
                        .WithMany("BookingDetails")
                        .HasForeignKey("ProductSupplierId")
                        .HasConstraintName("FK_BookingDetails_Products_Suppliers");

                    b.HasOne("TravelExpertsData.Region", "Region")
                        .WithMany("BookingDetails")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_BookingDetails_Regions");

                    b.Navigation("Booking");

                    b.Navigation("Class");

                    b.Navigation("Fee");

                    b.Navigation("ProductSupplier");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("TravelExpertsData.CreditCard", b =>
                {
                    b.HasOne("TravelExpertsData.Customer", "Customer")
                        .WithMany("CreditCards")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("CreditCards_FK00");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TravelExpertsData.Customer", b =>
                {
                    b.HasOne("TravelExpertsData.Agent", "Agent")
                        .WithMany("Customers")
                        .HasForeignKey("AgentId")
                        .HasConstraintName("FK_Customers_Agents");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("TravelExpertsData.CustomersReward", b =>
                {
                    b.HasOne("TravelExpertsData.Customer", "Customer")
                        .WithMany("CustomersRewards")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("Customers_Rewards_FK00");

                    b.HasOne("TravelExpertsData.Reward", "Reward")
                        .WithMany("CustomersRewards")
                        .HasForeignKey("RewardId")
                        .IsRequired()
                        .HasConstraintName("Customers_Rewards_FK01");

                    b.Navigation("Customer");

                    b.Navigation("Reward");
                });

            modelBuilder.Entity("TravelExpertsData.PackagesProductsSupplier", b =>
                {
                    b.HasOne("TravelExpertsData.Package", "Package")
                        .WithMany("PackagesProductsSuppliers")
                        .HasForeignKey("PackageId")
                        .IsRequired()
                        .HasConstraintName("Packages_Products_Supplie_FK00");

                    b.HasOne("TravelExpertsData.ProductsSupplier", "ProductSupplier")
                        .WithMany("PackagesProductsSuppliers")
                        .HasForeignKey("ProductSupplierId")
                        .IsRequired()
                        .HasConstraintName("Packages_Products_Supplie_FK01");

                    b.Navigation("Package");

                    b.Navigation("ProductSupplier");
                });

            modelBuilder.Entity("TravelExpertsData.ProductsSupplier", b =>
                {
                    b.HasOne("TravelExpertsData.Product", "Product")
                        .WithMany("ProductsSuppliers")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("Products_Suppliers_FK00");

                    b.HasOne("TravelExpertsData.Supplier", "Supplier")
                        .WithMany("ProductsSuppliers")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("Products_Suppliers_FK01");

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("TravelExpertsData.SupplierContact", b =>
                {
                    b.HasOne("TravelExpertsData.Affiliation", "Affiliation")
                        .WithMany("SupplierContacts")
                        .HasForeignKey("AffiliationId")
                        .HasConstraintName("SupplierContacts_FK00");

                    b.HasOne("TravelExpertsData.Supplier", "Supplier")
                        .WithMany("SupplierContacts")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("SupplierContacts_FK01");

                    b.Navigation("Affiliation");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("TravelExpertsData.Affiliation", b =>
                {
                    b.Navigation("SupplierContacts");
                });

            modelBuilder.Entity("TravelExpertsData.Agency", b =>
                {
                    b.Navigation("Agents");
                });

            modelBuilder.Entity("TravelExpertsData.Agent", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("TravelExpertsData.Booking", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("TravelExpertsData.Class", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("TravelExpertsData.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CreditCards");

                    b.Navigation("CustomersRewards");
                });

            modelBuilder.Entity("TravelExpertsData.Fee", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("TravelExpertsData.Package", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("PackagesProductsSuppliers");
                });

            modelBuilder.Entity("TravelExpertsData.Product", b =>
                {
                    b.Navigation("ProductsSuppliers");
                });

            modelBuilder.Entity("TravelExpertsData.ProductsSupplier", b =>
                {
                    b.Navigation("BookingDetails");

                    b.Navigation("PackagesProductsSuppliers");
                });

            modelBuilder.Entity("TravelExpertsData.Region", b =>
                {
                    b.Navigation("BookingDetails");
                });

            modelBuilder.Entity("TravelExpertsData.Reward", b =>
                {
                    b.Navigation("CustomersRewards");
                });

            modelBuilder.Entity("TravelExpertsData.Supplier", b =>
                {
                    b.Navigation("ProductsSuppliers");

                    b.Navigation("SupplierContacts");
                });

            modelBuilder.Entity("TravelExpertsData.TripType", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
