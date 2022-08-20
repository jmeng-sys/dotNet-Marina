using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214_Marina.Data
{   
    public class AuthenticationManager
    {
        // authenticate if a customer is in the database
        public static CustomerDTO Authenticate (string fname, string lname)
        {
            CustomerDTO dto = null;
            var db = new MarinaEntities();
            var cust =
                db.Customers.SingleOrDefault(a => a.FirstName == fname && a.LastName == lname);
            if (cust != null)
            {
                //authentication passed
                dto = new CustomerDTO
                {
                    ID = cust.ID,
                    FullName = $"{cust.FirstName} {cust.LastName}"
                };
            }
            return dto;
        }

        // add a new customer to MarinaEntities
        public static void AddCustomer(Customer cust)
        {
            var db = new MarinaEntities();
            db.Customers.Add(cust);
            db.SaveChanges();
        }

        // add a new lease to MarinaEntities
        public static void AddLease(Lease lease)
        {
            var db = new MarinaEntities();
            db.Leases.Add(lease);
            db.SaveChanges();
        }

    }
}
