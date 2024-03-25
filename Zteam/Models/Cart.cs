using System.ComponentModel.DataAnnotations;

namespace Zteam.Models
{
    public class Cart
    {
        [Key]
        public string CartId { get; set; }
        public string? CusId { get; set; }
        public string? CartDate { get; set; }
        public string? CartMoney { get; set; }
        public string? CartQty { get; set; }
        public string? CartCf { get; set; }
        public string? CartPay { get; set; }
    }
}
