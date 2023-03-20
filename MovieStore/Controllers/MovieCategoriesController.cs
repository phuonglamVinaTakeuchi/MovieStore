using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MovieStore.Data;

namespace MovieStore.Controllers
{
  public class MovieCategoriesController : Controller
  {
    private readonly AppDbContext _dbContext;
    public MovieCategoriesController(AppDbContext appDbContext)
    {
      _dbContext = appDbContext;
    }
    public async Task<IActionResult> Index()
    {
      var movieCategories = await _dbContext.MovieCategories.ToListAsync();
      return View(movieCategories);
    }
  }
}
