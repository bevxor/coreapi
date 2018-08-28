using System.ComponentModel.DataAnnotations;

namespace CoreApi.Entity.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string OrderName { get; set; }

        public Customer Customer { get; set; }
    }
}