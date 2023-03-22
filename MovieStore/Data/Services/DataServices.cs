using AutoMapper;
using MovieStore.Data.Repositories;

namespace MovieStore.Data.Services
{
  public class DataServices : IDataServices
  {
    private readonly Lazy<IActorService> _actorService;
    public readonly Lazy<IMovieCategoryService>  _movieCategoryService;


    public IActorService ActorService => _actorService.Value;
    public IMovieCategoryService MovieCategoryService => _movieCategoryService.Value;

    public DataServices(IRepositoryManager repositoryManager, IMapper mapper)
    {
      _actorService = new Lazy<IActorService>(() => new
        ActorService(repositoryManager,mapper));
      _movieCategoryService = new Lazy<IMovieCategoryService>(()=>new
        MovieCategoryService(repositoryManager,mapper));
    }

    public TService GetService<TService,TRepository,TEntity>() where TService : IServiceBase<TEntity>
    {
      var serviceType = typeof(TService);

      return serviceType.Name switch
      {
        nameof(IActorService) => (TService)ActorService,
        nameof(IMovieCategoryService) => (TService)MovieCategoryService,
        _ => throw new ArgumentOutOfRangeException(nameof(serviceType))
      };
    }
  }
}
