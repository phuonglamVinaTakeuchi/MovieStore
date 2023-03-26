using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Data.Services;

public class ActorService : ServiceBase<IActorRepository,ActorViewModel,Actor>, IActorService
{
  public ActorService(IRepositoryManager repository, IMapper mapper) : base(repository, mapper)
  {
  }
}