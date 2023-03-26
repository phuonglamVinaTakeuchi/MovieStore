using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Data.Services;

public class MovieCategoryService : ServiceBase<IMovieCategoryRepository, MovieCategoryViewModel, MovieCategory>, IMovieCategoryService
{
  public MovieCategoryService(IRepositoryManager repository, IMapper mapper) : base(repository, mapper)
  {
  }
}