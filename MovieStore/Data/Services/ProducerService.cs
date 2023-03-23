using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore.Data.Services;

public class ProducerService : ServiceBase<IProducerRepository,ProducerViewModel,Producer>,IProducerService
{
  public ProducerService(IRepositoryManager repositoryManager, IMapper mapper) : base(repositoryManager, mapper)
  {
  }
}