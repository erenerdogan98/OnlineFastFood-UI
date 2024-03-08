

using Microsoft.AspNetCore.Identity;
using OnlineFastFoodEntityLayer.Abstract;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
    }
}
