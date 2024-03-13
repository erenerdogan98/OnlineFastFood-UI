using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class SubCategoryManager(ISubCategoryDAL subCategoryDAL) : ISubCategoryService
    {
        private readonly ISubCategoryDAL _subCategoryDAL = subCategoryDAL ?? throw new ArgumentException(nameof(subCategoryDAL));

        public async Task TAddAsync(SubCategory subCategory) => await _subCategoryDAL.AddAsync(subCategory);
        public async Task TDeleteAsync(SubCategory subCategory) => await _subCategoryDAL.DeleteAsync(subCategory);
        public async Task<IEnumerable<SubCategory>> TGetAllAsync() => await _subCategoryDAL.GetAllAsync();

        public async Task<IEnumerable<SubCategory>> TGetAllAsync(Expression<Func<SubCategory, bool>> filter) => await _subCategoryDAL.GetAllAsync(filter);

        public async Task<SubCategory> TGetByIdAsync(int id) => await _subCategoryDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(SubCategory subCategory) => await _subCategoryDAL.UpdateAsync(subCategory);
    }
}
