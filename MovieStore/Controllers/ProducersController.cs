using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;

namespace MovieStore.Controllers
{
  public class ProducersController : Controller
  {
    private readonly AppDbContext _dbContext;
    public ProducersController(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }
    public async Task<IActionResult> Index()
    {
      var producers = await _dbContext.Producers.ToListAsync();
      return View(producers);
    }
  }
}
