using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class ActorRepository : RepositoryBase<Actor>, IActorRepository
  {
    public ActorRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IEnumerable<Actor>> GetAllAsync(bool trackChanges) =>
      await FindAll(trackChanges).OrderBy(a=>a.FullName).ToListAsync();

    public async Task<Actor?> GetActorAsync(int id, bool trackChanges) =>
      await FindByCondition(a => a.Id == id, trackChanges).SingleOrDefaultAsync();

    public void CreateActor(Actor actor) => Create(actor);

    public void DeleteActor(Actor actor) => Delete(actor);
  }
}
