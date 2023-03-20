using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T: class,IEntityBase,new()
{
  private readonly AppDbContext _dbContext;

  protected AppDbContext DbContext => _dbContext;

  public RepositoryBase(AppDbContext dbContext)
          => _dbContext = dbContext;
  public IQueryable<T> FindAll(bool trackChanges) =>
      !trackChanges ?
        DbContext.Set<T>()
          .AsNoTracking() :
        DbContext.Set<T>();

  public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
    bool trackChanges) =>
    !trackChanges ?
      DbContext.Set<T>()
        .Where(expression)
        .AsNoTracking() :
      DbContext.Set<T>()
        .Where(expression);

  public void Create(T entity) => DbContext.Set<T>().Add(entity);

  public void Update(T entity) => DbContext.Set<T>().Update(entity);

  public void Delete(T entity) => DbContext.Set<T>().Remove(entity);
}