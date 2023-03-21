using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.Entities;

namespace MovieStore.Controllers
{
  public class MovieCategoriesController : MovieStoreControllerBase<IMovieCategoryService,IMovieCategoryRepository,MovieCategory>
  {
    
    public MovieCategoriesController(IDataServices dataServices) : base(dataServices)
    {
     
    }
  }
}
