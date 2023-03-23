using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Data.Services;

public class MovieService : ServiceBase<IMovieRepository,MovieViewModel,Movie>, IMovieService
{
  public MovieService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
  {
  }
}