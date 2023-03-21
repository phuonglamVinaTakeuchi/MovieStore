using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Services;

namespace MovieStore.Controllers
{
  public abstract class MovieStoreControllerBase<TService,TRepository,TEntity> : Controller where TService: IServiceBase<TEntity>
  {
    private readonly IDataServices _dataServices;

    protected IDataServices DataServices => _dataServices;

    protected MovieStoreControllerBase(IDataServices dataServices)
    {
      _dataServices = dataServices;
    }

    public async Task<IActionResult> Index()
    {
      var service = DataServices.GetService<TService, TRepository, TEntity>();
      var entities = await service?.GetAllAsync(false)!;
      return View(entities);
    }

    public async Task<IActionResult> Detail(int id)
    {
      var service = DataServices.GetService<TService, TRepository, TEntity>();

      var entity = await service?.GetByIdAsync(id, false)!;

      return entity == null ? View("NotFound") : View(entity);
    }

    #region Edit

    public async Task<IActionResult> Edit(int id)
    {
      var service = DataServices.GetService<TService,TRepository, TEntity>();

      var entity = await service?.GetByIdAsync(id, false)!;

      if (entity == null)
      {
        return View("NotFound");
      }
      return View(entity);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, TEntity editedEntity)
    {
      var service = DataServices.GetService<TService, TRepository, TEntity>();

      await service?.UpdateAsync(id, editedEntity)!;

      return RedirectToAction("Index");
    }

    #endregion

    #region Delete

    public async Task<IActionResult> Delete(int id)
    {
      var service = DataServices.GetService<TService, TRepository, TEntity>();

      var entity = await service?.GetByIdAsync(id, false)!;

      if (entity == null)
      {
        return View("NotFound");
      }
      return View(entity);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirm(int id)
    {
      var service = DataServices.GetService<TService, TRepository, TEntity>();
      await service?.DeleteAsync(id)!;
      return RedirectToAction("Index");
    }

    #endregion

    #region Create

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind] TEntity entity)
    {
      if (ModelState.IsValid)
      {
        var service = DataServices.GetService<TService, TRepository, TEntity>();

        await service?.AddAsync(entity)!;
      }

      return RedirectToAction("Index");
    }
    #endregion

  }
}
