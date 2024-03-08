using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class SubCategory : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        // Relationship between 'Category' table
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Item> Items { get; set; }
    }
}
