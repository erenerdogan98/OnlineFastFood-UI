using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class Cart : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        // Relationship between Itm
        public int ItemId { get; set; }
        public Item Item { get; set; }

        // Relationship between AppUser
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }

        public int Count { get; set; }
    }
}
