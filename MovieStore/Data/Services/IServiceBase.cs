namespace MovieStore.Data.Services;

public interface IServiceBase<TEntityViewModel>
{
  Task<IEnumerable<TEntityViewModel>> GetAllAsync(bool trackChanges);
  Task<TEntityViewModel?> GetByIdAsync(int id, bool trackChanges);
  Task AddAsync(TEntityViewModel actor);
  Task UpdateAsync(int id, TEntityViewModel newActor);
  Task DeleteAsync(int id);

}