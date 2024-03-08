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
    }
}
