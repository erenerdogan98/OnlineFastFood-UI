using System.Linq.Expressions;

namespace OnlineFastFood_BusinessLogicLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TAddAsync(T entity);
        Task TDeleteAsync(T entity);
        Task TUpdateAsync(T entity);
        Task<IEnumerable<T>> TGetAllAsync();
        Task<T> TGetByIdAsync(int id);
        Task<IEnumerable<T>> TGetAllAsync(Expression<Func<T, bool>> filter);
    }
}
