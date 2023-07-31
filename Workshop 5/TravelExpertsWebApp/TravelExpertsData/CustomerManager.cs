using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class CustomerManager
    {
        public static List<Customer> GetCustomers(TravelExpertsContext db)
        {
            var list = db.Customers.ToList();
            return list;
        }

        public static bool AddCustomer(Customer cust, TravelExpertsContext db)
        {
            bool success = false;
            if (cust != null) 
            {
                db.Customers.Add(cust);
                db.SaveChanges();
                success = true;
            }
            return success;
            
        }

        public static bool RemoveCustomer(Customer cust, TravelExpertsContext db) 
        {
            bool success = false;
            if (cust != null)
            {
                db.Customers.Remove(cust);
                db.SaveChanges();
                success = true;
            }
            return success;
        }

        // unsure if I need to make this customer nullable
        public static Customer? GetCustomerById(int id, TravelExpertsContext db)
        {
            Customer cust = db.Customers.Find(id);
            return cust;
        }

        public static Customer Authenticate(string username, string password, TravelExpertsContext db)
        {
            List<Customer> customers = GetCustomers(db);
            var customer = customers.SingleOrDefault(c => (c.CustUsername == username) && (c.CustPassword == password));
            return customer; 
        }
    }
}
