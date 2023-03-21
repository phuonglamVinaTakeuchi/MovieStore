using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.Exceptions;

namespace MovieStore.Data.Services;

public class ActorService : ServiceBase<IActorRepository,Actor>, IActorService
{
  public ActorService(IRepositoryManager repository, IMapper mapper) : base(repository, mapper)
  {
  }
}