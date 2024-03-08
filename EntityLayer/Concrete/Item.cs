using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class Item : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        // Relationship between 'Category'
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Relationship between 'SubCategory' 
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
