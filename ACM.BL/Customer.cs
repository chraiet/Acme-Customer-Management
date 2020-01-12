using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(FirstName))
                    return LastName;
                else if (string.IsNullOrEmpty(LastName))
                    return FirstName;
                else
                    return $"{LastName}, {FirstName}";
            }
        }

        public static int InstanceCount { get; set; }

        //  Retrieve one customer.
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        //  Retrieve all customers.
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        //  Saves the current customer.
        public bool Save()
        {
            return true;
        }

        //  Validates the customer data.
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
