using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class Coupon : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public double Discount { get; set; }
        public double MinimalAmount { get; set; }
        public byte[] CouponPicture { get; set; }
        public bool IsActive { get; set; } = false;
    }

    public enum CouponType
    {
        Percent = 0,
        Currency = 1
    }
}
