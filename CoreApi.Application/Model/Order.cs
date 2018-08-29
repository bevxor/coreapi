using CoreApi.Application.Model;

namespace CoreApi.Application.Model
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderName { get; set; }

        public Customer Customer { get; set; }
    }
}