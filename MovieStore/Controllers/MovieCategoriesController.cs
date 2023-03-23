using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Controllers
{
  public class MovieCategoriesController : MovieStoreControllerBase<IMovieCategoryService,IMovieCategoryRepository,MovieCategoryViewModel>
  {
    public MovieCategoriesController(IDataServices dataServices) : base(dataServices)
    {
     
    }
  }
}
