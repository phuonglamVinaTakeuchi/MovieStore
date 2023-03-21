namespace MovieStore.Data.Services;

public interface IServiceBase<TEntity>
{
  Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges);
  Task<TEntity?> GetByIdAsync(int id, bool trackChanges);
  Task AddAsync(TEntity actor);
  Task UpdateAsync(int id, TEntity newActor);
  Task DeleteAsync(int id);

}