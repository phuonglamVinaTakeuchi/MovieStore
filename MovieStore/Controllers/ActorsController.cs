using Microsoft.AspNetCore.Mvc;
using MovieStore.Data.Repositories;
using MovieStore.Data.Services;
using MovieStore.Models.Entities;

namespace MovieStore.Controllers
{
  public class ActorsController : MovieStoreControllerBase<IActorService,IActorRepository,Actor>
  {
    public ActorsController(IDataServices dataServices) : base(dataServices)
    {
      
    }
  }
}
