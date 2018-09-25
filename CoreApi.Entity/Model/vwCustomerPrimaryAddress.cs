using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreApi.Entity.Model
{
    public class vwCustomerPrimaryAddress
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        public List<CustomerAddress> CustomerAddresses { get; set; }

        public List<Order> Orders { get; set; }
    }
}