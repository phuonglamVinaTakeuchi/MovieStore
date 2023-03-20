using MovieStore.Data.Repositories;

namespace MovieStore.Data.Services
{
  public class DataServices : IDataServices
  {
    private readonly Lazy<IActorService> _orderService;
    
    public IActorService ActorService => _orderService.Value;


    public DataServices(IRepositoryManager repositoryManager)
    {
      _orderService = new Lazy<IActorService>(() => new
        ActorService(repositoryManager));
    }
  }
}
