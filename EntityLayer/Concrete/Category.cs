using OnlineFastFoodEntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class Category : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        // relations , which category used ..
        public List<SubCategory> SubCategories { get; set; }
        public List<Item> Items { get; set; }
    }
}
