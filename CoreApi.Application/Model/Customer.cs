using System.Collections.Generic;

namespace CoreApi.Application.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public List<CustomerAddress> CustomerAddresses { get; set; }

        public List<Order> Orders { get; set; }

    }
}