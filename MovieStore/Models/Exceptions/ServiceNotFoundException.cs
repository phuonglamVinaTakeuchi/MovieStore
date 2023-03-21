using MovieStore.Data.Services;

namespace MovieStore.Models.Exceptions;
public class ServiceNotFoundException<TService,TRepository,TEntity> : NotFoundException
  where TService : IServiceBase<TEntity>
{
  public ServiceNotFoundException() : base($"The service {typeof(TService).Name} is not available")
  {
  }
}