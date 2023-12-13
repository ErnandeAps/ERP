using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Base.Repository.FireBirdRepository;

public class DatabaseRepository<T>: IDatabaseRepository<T> where T: class
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public DatabaseRepository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.AsQueryable().ToListAsync();
    }

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task Add(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task Update(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public Task Delete(T entity)
    {
        _dbSet.Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<bool> Commit()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}