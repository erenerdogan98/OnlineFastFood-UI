using OnlineFastFood_BusinessLogicLayer.Abstract;
using OnlineFastFood_DataAccessLayer.Abstract;
using OnlineFastFoodEntityLayer.Concrete;
using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Concrete
{
    public class CouponManager(ICouponDAL couponDAL) : ICouponService
    {
        private readonly ICouponDAL _couponDAL = couponDAL ?? throw new ArgumentException(nameof(couponDAL));

        public async Task TAddAsync(Coupon coupon) => await _couponDAL.AddAsync(coupon);

        public async Task TDeleteAsync(Coupon coupon) => await _couponDAL.DeleteAsync(coupon);

        public async Task<IEnumerable<Coupon>> TGetAllAsync() => await _couponDAL.GetAllAsync();

        public async Task<IEnumerable<Coupon>> TGetAllAsync(Expression<Func<Coupon, bool>> filter) => await _couponDAL.GetAllAsync(filter);

        public async Task<Coupon> TGetByIdAsync(int id) => await _couponDAL.GetByIdAsync(id);

        public async Task TUpdateAsync(Coupon coupon) => await _couponDAL.UpdateAsync(coupon);
    }
}
