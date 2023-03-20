using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;

namespace MovieStore.Controllers
{
  public class MoviesController : Controller
  {
    private readonly AppDbContext _dbContext;

    public MoviesController(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    public async Task<IActionResult> Index()
    {
      var movies = await _dbContext
        .Movies
        .Include(m=>m.Cinema)
        .Include(m=>m.MovieCategory)
        .ToListAsync();
      return View(movies);
    }
  }
}
