using System.ComponentModel.DataAnnotations;

namespace SPORTS_STORE.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
