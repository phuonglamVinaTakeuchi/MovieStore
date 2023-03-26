using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.ViewModels;

namespace MovieStore.Controllers
{
  public class MoviesController : MovieStoreControllerBase<IMovieService,IMovieRepository,MovieViewModel>
  {
    public MoviesController(IDataServices dataServices) : base(dataServices)
    {
    }

    //public async Task<IActionResult> Index()
    //{
    //  var movies = await _dbContext.Set<Movie>()
    //    .Include(m=>m.Cinema)
    //    .Include(m=>m.MovieCategory)
    //    .ToListAsync();
    //  return View(movies);
    //}
  }
}
