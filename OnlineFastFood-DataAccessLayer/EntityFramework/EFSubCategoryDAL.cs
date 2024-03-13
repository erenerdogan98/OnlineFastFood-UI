using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Concrete;
using OnlineFastFood_DataAccessLayer.Repositories;
using OnlineFastFoodEntityLayer.Concrete;

namespace OnlineFastFood_DataAccessLayer.EntityFramework
{
    public class EFSubCategoryDAL(Context context) : GenericRepository<SubCategory>(context), ISubCategoryDAL
    {
    }
}
