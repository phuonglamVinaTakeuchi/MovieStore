using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.Exceptions;

namespace MovieStore.Data.Services;

public class ActorService : IActorService
{
  private readonly IRepositoryManager _repository;
  public ActorService(IRepositoryManager repository)
  {
    _repository = repository;
  }
  public async Task<IEnumerable<Actor>> GetAllAsync(bool trackChanges)
  {
    return await _repository.ActorRepository.GetAllAsync(trackChanges);
  }

  public async Task<Actor?> GetByIdAsync(int id, bool trackChanges)
  {
    return await _repository.ActorRepository.GetActorAsync(id,trackChanges);
  }

  public async Task AddAsync(Actor actor)
  {
    _repository.ActorRepository.CreateActor(actor);
    await _repository.SaveAsync();
  }

  public async Task UpdateAsync(int id, Actor newActor, bool trackChanges)
  {
    var actor = await GetActorAndCheckIfItExists(id, trackChanges);
    
    actor.FullName = newActor.FullName;
    actor.ProfilePictureUrl = newActor.ProfilePictureUrl;
    actor.Bio = newActor.Bio;

    await _repository.SaveAsync();
  }

  public async Task DeleteAsync(int id)
  {
    var company = await GetActorAndCheckIfItExists(id, false);
    _repository.ActorRepository.DeleteActor(company);
    await _repository.SaveAsync();
  }

  private async Task<Actor> GetActorAndCheckIfItExists(int id, bool trackChanges)
  {
    var company = await _repository.ActorRepository.GetActorAsync(id, trackChanges);
    if (company is null)
    {
      throw new ActorNotFoundException(id);
    }
    else
    {
      return company;
    }
  }
}