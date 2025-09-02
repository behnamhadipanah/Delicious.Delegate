using System.Linq.Expressions;
using Delicious.Delegate.LinqDelegate.DB;
using Microsoft.EntityFrameworkCore;

namespace Delicious.Delegate.LinqDelegate;

public class BaseDelegateQuery<TTable> where TTable : class
{
    MyDbContext _context;
    DbSet<TTable> _dbSet;
    public BaseDelegateQuery(MyDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TTable>();
    }

    public IEnumerable<TTable> MyQuery(Expression<Func<TTable, bool>> func)
    {
        
        
        return _dbSet.Where(func).ToList();
    }
    
    public bool MyAny(Expression<Func<TTable, bool>> func)
    {
        
        
        return _dbSet.Any(func);
    }
}