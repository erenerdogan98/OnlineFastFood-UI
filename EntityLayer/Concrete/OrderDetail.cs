using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class OrderDetail : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        // Relationship between OrderHeader
        public int OrderHeaderId { get; set; }
        public OrderHeader OrderHeader { get; set; }

        // Relationship between Item
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
