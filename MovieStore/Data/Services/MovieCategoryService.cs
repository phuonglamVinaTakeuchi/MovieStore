using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Services
{
  public class MovieCategoryService : ServiceBase<IMovieCategoryRepository,MovieCategory>,IMovieCategoryService
  {
    public MovieCategoryService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }

  }
}
