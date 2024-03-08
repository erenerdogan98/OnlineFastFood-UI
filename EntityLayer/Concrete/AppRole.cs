using Microsoft.AspNetCore.Identity;
using OnlineFastFoodEntityLayer.Abstract;

namespace OnlineFastFoodEntityLayer.Concrete
{
    public class AppRole : IdentityRole<int>, IEntityBase
    {
    }
}
