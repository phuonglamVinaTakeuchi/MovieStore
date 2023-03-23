using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.ViewModels;

namespace MovieStore.Controllers
{
  public class CinemasController : MovieStoreControllerBase<ICinemaService,ICinemaRepository,CinemaViewModel>
  {
    public CinemasController(IDataServices dataServices) : base(dataServices)
    {
    }
  }
}
