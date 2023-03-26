using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class ActorRepository : RepositoryBase<Actor>, IActorRepository
  {
    public ActorRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
  }
}
