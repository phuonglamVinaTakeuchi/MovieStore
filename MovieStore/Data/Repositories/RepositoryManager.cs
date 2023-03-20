namespace MovieStore.Data.Repositories
{
  public class RepositoryManager : IRepositoryManager
  {

    private readonly AppDbContext _appDbContext;
    
    private readonly Lazy<IActorRepository> _actorRepository;
    public IActorRepository ActorRepository => _actorRepository.Value;

    public RepositoryManager(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
      _actorRepository = new Lazy<IActorRepository>(() => new ActorRepository(_appDbContext));
    }
    public async Task SaveAsync() => await _appDbContext.SaveChangesAsync();
    
  }
}
