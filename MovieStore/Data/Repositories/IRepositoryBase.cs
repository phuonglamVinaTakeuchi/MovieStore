using System.Linq.Expressions;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public interface IRepositoryBase <TEntity>
{
  IQueryable<TEntity> FindAll(bool trackChanges);
  IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression,
  bool trackChanges);
  Task Create(TEntity entity);
  void Update(TEntity entity);
  void Delete(TEntity entity);

  Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges);
  Task<TEntity?> GetByIdAsync(int id, bool trackChanges);
  Task CreateEntity(TEntity entity);
  void DeleteAsync(TEntity entity);
}