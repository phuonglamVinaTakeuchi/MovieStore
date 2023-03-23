using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public class ProducerRepository : RepositoryBase<Producer>, IProducerRepository
{
  public ProducerRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}