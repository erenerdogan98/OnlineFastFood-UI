using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class OrderHeader : IEntityBase
    {
        public int Id { get; set; }

        // Relationship between AppUser
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public DateTime TimeoOfPick { get; set; }
        public DateTime DateOfPick { get; set; }
        public double SubTotal { get; set; }
        public double OrderTotal { get; set; }
        public string CouponCode { get; set; }
        public double CouponDiscount { get; set; }
        public string TransId { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
