namespace CoreApi.Application.Model
{
    public class CustomerAddress
    {
        public int CustomerAddressId { get; set; }

        public bool PrimaryAddress { get; set; }

        public string Street { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public int PostCode { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}