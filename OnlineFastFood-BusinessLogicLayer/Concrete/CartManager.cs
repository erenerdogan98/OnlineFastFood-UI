using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class CartManager(ICartDAL cartDAL) : ICartService
    {
        private readonly ICartDAL _cartDAL = cartDAL ?? throw new ArgumentException();

        public async Task TAddAsync(Cart cart) => await _cartDAL.AddAsync(cart);

        public async Task TDeleteAsync(Cart cart) => await _cartDAL.DeleteAsync(cart);

        public async Task<IEnumerable<Cart>> TGetAllAsync() => await _cartDAL.GetAllAsync();

        public async Task<IEnumerable<Cart>> TGetAllAsync(Expression<Func<Cart, bool>> filter) => await _cartDAL.GetAllAsync(filter);

        public async Task<Cart> TGetByIdAsync(int id) => await _cartDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(Cart cart) => await _cartDAL.UpdateAsync(cart);
    }
}
