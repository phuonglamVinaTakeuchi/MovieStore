using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;

namespace MovieStore.Controllers
{
  public class CinemasController : Controller
  {
    private readonly AppDbContext _appDbContext;
    public CinemasController(AppDbContext appDbAppDbContext)
    {
      _appDbContext = appDbAppDbContext;
    }
    public async Task<IActionResult> Index()
    {
      var allCinemas =  await _appDbContext.Cinemas.ToListAsync();
      return View(allCinemas);
    }
  }
}
