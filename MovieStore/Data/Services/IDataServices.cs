namespace MovieStore.Data.Services;

public interface IDataServices
{
  IActorService ActorService { get; }

  TService GetService<TService,TRepository,TEntityViewModel>() where TService: IServiceBase<TEntityViewModel>;
}