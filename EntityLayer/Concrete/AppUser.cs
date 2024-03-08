

using Microsoft.AspNetCore.Identity;
using OnlineFastFoodEntityLayer.Abstract;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>, IEntityBase
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public List<OrderHeader> OrderHeaders { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
