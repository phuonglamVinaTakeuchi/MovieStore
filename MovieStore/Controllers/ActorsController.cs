using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.ViewModels;

namespace MovieStore.Controllers
{
  public class ActorsController : MovieStoreControllerBase<IActorService,IActorRepository,ActorViewModel>
  {
    public ActorsController(IDataServices dataServices) : base(dataServices)
    {
      
    }
  }
}
