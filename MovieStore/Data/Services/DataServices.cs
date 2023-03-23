using AutoMapper;
using MovieStore.Data.Repositories;

namespace MovieStore.Data.Services
{
  public class DataServices : IDataServices
  {
    private readonly Lazy<IActorService> _actorService;
    private readonly Lazy<IMovieCategoryService>  _movieCategoryService;
    private readonly Lazy<IProducerService>  _producerService;
    private readonly Lazy<ICinemaService> _cinemaService;
    private readonly Lazy<IMovieService> _movieService;


    public IActorService ActorService => _actorService.Value;
    public IMovieCategoryService MovieCategoryService => _movieCategoryService.Value;
    public IProducerService ProducerService => _producerService.Value;
    public ICinemaService CinemaService => _cinemaService.Value;
    public IMovieService MovieService => _movieService.Value;

    public DataServices(IRepositoryManager repositoryManager, IMapper mapper)
    {
      _actorService = new Lazy<IActorService>(() => new
        ActorService(repositoryManager,mapper));
      _movieCategoryService = new Lazy<IMovieCategoryService>(()=>new
        MovieCategoryService(repositoryManager,mapper));
      _producerService = new Lazy<IProducerService>(() => new
        ProducerService(repositoryManager, mapper));
      _cinemaService = new Lazy<ICinemaService>(() => new CinemaService(repositoryManager, mapper));
      _movieService = new Lazy<IMovieService>(() => new MovieService(repositoryManager, mapper));
    }

    public TService GetService<TService,TRepository,TEntity>() where TService : IServiceBase<TEntity>
    {
      var serviceType = typeof(TService);

      return serviceType.Name switch
      {
        nameof(IActorService) => (TService)ActorService,
        nameof(IMovieCategoryService) => (TService)MovieCategoryService,
        nameof(IProducerService) => (TService)ProducerService,
        nameof(ICinemaService) => (TService)CinemaService,
        nameof(IMovieService) => (TService)MovieService,
        _ => throw new ArgumentOutOfRangeException(nameof(serviceType))
      };
    }
  }
}
