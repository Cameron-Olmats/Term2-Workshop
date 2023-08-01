/*
 * Customer manager. Customers act as the applications accounts so this class includes an authenticate method
 * Functions: Add, Update, Remove, update agent id, GetCustomerById
 */

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

        /// <summary>
        /// Method for updating customer info. Username, Password and Agent ID not included.
        /// </summary>
        /// <param name="id">Id of the customer you want to modify</param>
        /// <param name="newCustomer">customer object with new data</param>
        /// <param name="db">database context</param>
        public static void UpdateCustomer(int id, Customer newCustomer, TravelExpertsContext db)
        {
            Customer cust = db.Customers.Find(id);
            if (cust != null)
            {
                cust.CustFirstName = newCustomer.CustFirstName;
                cust.CustLastName = newCustomer.CustLastName;
                cust.CustAddress = newCustomer.CustAddress;
                cust.CustCity = newCustomer.CustCity;
                cust.CustProv = newCustomer.CustProv;
                cust.CustPostal = newCustomer.CustPostal;
                cust.CustCountry = newCustomer.CustCountry;
                cust.CustHomePhone = newCustomer.CustHomePhone;
                cust.CustBusPhone = newCustomer.CustBusPhone;
                cust.CustEmail = newCustomer.CustEmail;
                //cust.CustUsername = newCustomer.CustUsername;
                //cust.CustPassword = newCustomer.CustPassword;
                //cust.CustConfirmPassword = newCustomer.CustConfirmPassword;
                // Might wanna use a different process for changing the username and passwords?

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Method for updating a customers agent.
        /// </summary>
        /// <param name="customerId">The ID of the customer you want to update</param>
        /// <param name="agentId">The ID of the agent you want to assign to the customer</param>
        /// <param name="db">database context</param>
        public static void AddAgentToCustomer(int customerId, int agentId, TravelExpertsContext db)
        {
            Customer cust = db.Customers.Find(customerId);
            if (cust != null)
            {
                cust.AgentId = agentId;
            }
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
