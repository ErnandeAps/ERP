using System.Linq.Expressions;

namespace Base.Repository.FireBirdRepository;

public interface IDatabaseRepository<T> where T: class
{
    Task<IEnumerable<T>> GetAll();
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    Task<T> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<bool> Commit();

}