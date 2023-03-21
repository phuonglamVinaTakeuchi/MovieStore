namespace MovieStore.Data.Services;

public interface IDataServices
{
  IActorService ActorService { get; }

  TService? GetService<TService,TRepository,TEntity>() where TService: IServiceBase<TEntity>;
}