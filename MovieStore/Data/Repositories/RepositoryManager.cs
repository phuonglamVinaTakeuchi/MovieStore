using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class RepositoryManager : IRepositoryManager
  {

    private readonly AppDbContext _appDbContext;
    
    private readonly Lazy<IActorRepository> _actorRepository;
    private readonly Lazy<IMovieCategoryRepository> _movieCategoryRepository;
    public IActorRepository ActorRepository => _actorRepository.Value;
    public IMovieCategoryRepository MovieCategoryRepository => _movieCategoryRepository.Value;

    public RepositoryManager(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
      _actorRepository = new Lazy<IActorRepository>(() => new ActorRepository(_appDbContext));
      _movieCategoryRepository = new Lazy<IMovieCategoryRepository>(() => new MovieCategoryRepository(_appDbContext));
    }

    public TRepository GetRepository<TRepository,TEntity>() 
      where TRepository : IRepositoryBase<TEntity>
    
    {
      return typeof(TRepository).Name switch
      {
        nameof(IActorRepository) => (TRepository)ActorRepository,
        nameof(IMovieCategoryRepository) => (TRepository)ActorRepository,
        _ => throw new ArgumentOutOfRangeException()
      };
    }

    public async Task SaveAsync() => await _appDbContext.SaveChangesAsync();
    
  }
}
