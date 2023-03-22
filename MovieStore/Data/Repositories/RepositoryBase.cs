using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
  where TEntity : class, IEntityBase
{
  protected AppDbContext DbContext { get; }

  public RepositoryBase(AppDbContext dbContext)
          => DbContext = dbContext;
  public IQueryable<TEntity> FindAll(bool trackChanges) =>
      !trackChanges ?
        DbContext.Set<TEntity>()
          .AsNoTracking() :
        DbContext.Set<TEntity>();

  public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression,
    bool trackChanges) =>
    !trackChanges ?
      DbContext.Set<TEntity>()
        .Where(expression)
        .AsNoTracking() :
      DbContext.Set<TEntity>()
        .Where(expression);

  public async Task Create(TEntity entity) => await DbContext.Set<TEntity>().AddAsync(entity);

  public void Update(TEntity entity) => DbContext.Set<TEntity>().Update(entity);

  public void Delete(TEntity entity) => DbContext.Set<TEntity>().Remove(entity);

  public async Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges) => await
    FindAll(trackChanges)
      .ToListAsync();

  public async Task<TEntity?> GetByIdAsync(int id, bool trackChanges) => await
    FindByCondition(a => a.Id == id, trackChanges)
      .SingleOrDefaultAsync();

  public async Task CreateEntity(TEntity entity) => await Create(entity);

  public void DeleteAsync(TEntity entity) => Delete(entity);
}