using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class MovieCategoryRepository : RepositoryBase<MovieCategory>, IMovieCategoryRepository
  {
    public MovieCategoryRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
  }
}
