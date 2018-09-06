using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreApi.Application.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        public List<CustomerAddress> CustomerAddresses { get; set; }

        public List<Order> Orders { get; set; }

    }
}