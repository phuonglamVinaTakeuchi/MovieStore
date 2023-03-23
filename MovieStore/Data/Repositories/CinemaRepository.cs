using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class CinemaRepository : RepositoryBase<Cinema>, ICinemaRepository
  {
    public CinemaRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
  }
}
