using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class RepositoryManager : IRepositoryManager
  {

    private readonly AppDbContext _appDbContext;
    
    private readonly Lazy<IActorRepository> _actorRepository;
    private readonly Lazy<IMovieCategoryRepository> _movieCategoryRepository;
    private readonly Lazy<IProducerRepository> _producerRepository;
    private readonly Lazy<ICinemaRepository> _cinemaRepository;
    private readonly Lazy<IMovieRepository> _movieRepository;
    public IActorRepository ActorRepository => _actorRepository.Value;
    public IMovieCategoryRepository MovieCategoryRepository => _movieCategoryRepository.Value;
    public IProducerRepository ProducerRepository => _producerRepository.Value;
    public ICinemaRepository CinemaRepository => _cinemaRepository.Value;
    public IMovieRepository MovieRepository => _movieRepository.Value;

    public RepositoryManager(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
      _actorRepository = new Lazy<IActorRepository>(() => new ActorRepository(_appDbContext));
      _movieCategoryRepository = new Lazy<IMovieCategoryRepository>(() => new MovieCategoryRepository(_appDbContext));
      _producerRepository = new Lazy<IProducerRepository>(() => new ProducerRepository(_appDbContext));
      _cinemaRepository = new Lazy<ICinemaRepository>(() => new CinemaRepository(_appDbContext));
      _movieRepository = new Lazy<IMovieRepository>(() => new MovieRepository(_appDbContext));
    }

    public TRepository GetRepository<TRepository,TEntity>() 
      where TRepository : IRepositoryBase<TEntity>
    
    {
      return typeof(TRepository).Name switch
      {
        nameof(IActorRepository) => (TRepository)ActorRepository,
        nameof(IMovieCategoryRepository) => (TRepository)MovieCategoryRepository,
        nameof(IProducerRepository) => (TRepository)ProducerRepository,
        nameof(ICinemaRepository) => (TRepository)CinemaRepository,
        nameof(IMovieRepository) => (TRepository)MovieRepository,
        _ => throw new ArgumentOutOfRangeException()
      };
    }

    public async Task SaveAsync() => await _appDbContext.SaveChangesAsync();
    
  }
}
