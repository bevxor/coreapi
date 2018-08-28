using System.ComponentModel.DataAnnotations;

namespace CoreApi.Entity.Model
{
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressId { get; set; }

        [Required]
        public bool PrimaryAddress { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int PostCode { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}