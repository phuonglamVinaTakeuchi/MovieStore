using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;

namespace MovieStore.Models.Exceptions
{
  public class RepositoryNotFoundException<TRepository,TEntity> : NotFoundException
  where TRepository : IRepositoryBase<TEntity> 
  where TEntity : class,IEntityBase,new()
  {
    public RepositoryNotFoundException() : base($"The repository {typeof(TRepository).Name} is not available")
    {
    }
  }
}
