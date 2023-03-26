using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.ViewModels;

namespace MovieStore.Controllers
{
  public class ProducersController : MovieStoreControllerBase<IProducerService,IProducerRepository,ProducerViewModel>
  {
    public ProducersController(IDataServices dataServices) : base(dataServices)
    {
      
    }
  }
}
