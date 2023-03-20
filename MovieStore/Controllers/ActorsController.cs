using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Services;
using MovieStore.Models.Entities;

namespace MovieStore.Controllers
{
  public class ActorsController : Controller
  {
    private readonly IDataServices _dataServices;
    public ActorsController(IDataServices dataServices)
    {
      _dataServices = dataServices;
    }

    public async Task<IActionResult> Index()
    {
      var actors = await _dataServices.ActorService.GetAllAsync(false);
      return View(actors);
    }

    public async Task<IActionResult> Detail(int id)
    {
      var actor = await _dataServices.ActorService.GetByIdAsync(id, false);

      if (actor == null)
      {
        return View("NotFound");
      }
      return View(actor);
    }

    public async Task<IActionResult> Edit(int id)
    {
      var actor = await _dataServices.ActorService.GetByIdAsync(id, false);

      if (actor == null)
      {
        return View("NotFound");
      }
      return View(actor);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id,Actor editedActor)
    {
      await _dataServices.ActorService.UpdateAsync(id,editedActor,trackChanges:true);

      return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(int id)
    {
      var actor = await _dataServices.ActorService.GetByIdAsync(id, false);

      if (actor == null)
      {
        return View("NotFound");
      }
      return View(actor);
    }

    [HttpPost,ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirm(int id)
    {
      await _dataServices.ActorService.DeleteAsync(id);
      return RedirectToAction("Index");
    }
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("FullName,ProfilePictureUrl,Bio")]Actor actor)
    {
      if (ModelState.IsValid)
      {
        await _dataServices.ActorService.AddAsync(actor);
      }

      return RedirectToAction("Index");
    }
  }
}
