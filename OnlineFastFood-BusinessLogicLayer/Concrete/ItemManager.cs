using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class ItemManager(IItemDAL itemDAL) : IItemService
    {
        private readonly IItemDAL _itemDAL = itemDAL ?? throw new ArgumentException(nameof(itemDAL));

        public async Task TAddAsync(Item item) => await _itemDAL.AddAsync(item);

        public async Task TDeleteAsync(Item item) => await _itemDAL.DeleteAsync(item);

        public async Task<IEnumerable<Item>> TGetAllAsync() => await _itemDAL.GetAllAsync();

        public async Task<IEnumerable<Item>> TGetAllAsync(Expression<Func<Item, bool>> filter) => await _itemDAL.GetAllAsync(filter);

        public async Task<Item> TGetByIdAsync(int id) => await _itemDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(Item item) => await _itemDAL.UpdateAsync(item);
    }
}
