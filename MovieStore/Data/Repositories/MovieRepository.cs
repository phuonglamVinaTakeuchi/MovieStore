using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories
{
  public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
  {
    public MovieRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public override async Task<IEnumerable<Movie>> GetAllAsync(bool trackChanges) =>
      await FindAll(trackChanges)
        .Include(x => x.Cinema)
        .Include(m => m.MovieCategory)
        .ToListAsync();

    public override async Task<Movie?> GetByIdAsync(int id, bool trackChanges) =>
      await FindByCondition(a => a.Id == id, trackChanges)
        .Include(m=>m.Cinema)
        .Include(m => m.MovieCategory)
        .SingleOrDefaultAsync();
  }
}
