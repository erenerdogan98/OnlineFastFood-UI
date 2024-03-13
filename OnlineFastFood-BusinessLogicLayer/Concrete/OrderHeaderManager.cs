using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class OrderHeaderManager(IOrderHeaderDAL orderHeaderDAL) : IOrderHeaderService
    {
        private readonly IOrderHeaderDAL _orderHeaderDAL = orderHeaderDAL ?? throw new ArgumentException(nameof(orderHeaderDAL));

        public async Task TAddAsync(OrderHeader orderHeader) => await _orderHeaderDAL.AddAsync(orderHeader);

        public async Task TDeleteAsync(OrderHeader orderHeader) => await _orderHeaderDAL.DeleteAsync(orderHeader);

        public async Task<IEnumerable<OrderHeader>> TGetAllAsync() => await _orderHeaderDAL.GetAllAsync();

        public async Task<IEnumerable<OrderHeader>> TGetAllAsync(Expression<Func<OrderHeader, bool>> filter) => await _orderHeaderDAL.GetAllAsync(filter);

        public async Task<OrderHeader> TGetByIdAsync(int id) => await _orderHeaderDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(OrderHeader orderHeader) => await _orderHeaderDAL.UpdateAsync(orderHeader); 
    }
}
