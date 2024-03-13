using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class CategoryManager(ICategoryDAL categoryDAL) : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL = categoryDAL ?? throw new ArgumentException();

        public async Task TAddAsync(Category category) => await _categoryDAL.AddAsync(category);

        public async Task TDeleteAsync(Category entity) => await _categoryDAL.DeleteAsync(entity);

        public async Task<IEnumerable<Category>> TGetAllAsync() => await _categoryDAL.GetAllAsync();

        public async Task<IEnumerable<Category>> TGetAllAsync(Expression<Func<Category, bool>> filter) => await _categoryDAL.GetAllAsync(filter);

        public async Task<Category> TGetByIdAsync(int id) => await _categoryDAL.GetByIdAsync(id);

        public Task TUpdateAsync(Category category) => _categoryDAL.UpdateAsync(category);
    }
}
