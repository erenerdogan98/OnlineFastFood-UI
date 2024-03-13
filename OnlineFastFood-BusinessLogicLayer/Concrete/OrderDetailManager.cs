using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class OrderDetailManager(IOrderDetailDAL orderDetailDAL) : IOrderDetailService
    {
        private readonly IOrderDetailDAL _orderDetailDAL = orderDetailDAL ?? throw new ArgumentException(nameof(orderDetailDAL));

        public async Task TAddAsync(OrderDetail orderDetail) => await _orderDetailDAL.AddAsync(orderDetail);

        public async Task TDeleteAsync(OrderDetail orderDetail) => await _orderDetailDAL.DeleteAsync(orderDetail);

        public async Task<IEnumerable<OrderDetail>> TGetAllAsync() => await _orderDetailDAL.GetAllAsync();

        public async Task<IEnumerable<OrderDetail>> TGetAllAsync(Expression<Func<OrderDetail, bool>> filter) => await _orderDetailDAL.GetAllAsync(filter);

        public async Task<OrderDetail> TGetByIdAsync(int id) => await _orderDetailDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(OrderDetail orderDetail) => await _orderDetailDAL.UpdateAsync(orderDetail);
    }
}
