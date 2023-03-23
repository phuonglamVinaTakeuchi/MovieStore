using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Data.Services
{
  public class CinemaService : ServiceBase<ICinemaRepository,CinemaViewModel,Cinema>, ICinemaService
  {
    public CinemaService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
    {
    }
  }
}
