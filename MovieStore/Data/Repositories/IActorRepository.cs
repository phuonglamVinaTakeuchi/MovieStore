using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public interface IActorRepository
{
  Task<IEnumerable<Actor>> GetAllAsync(bool trackChanges);
  Task<Actor?> GetActorAsync(int id, bool trackChanges);
  void CreateActor(Actor actor);
  void DeleteActor(Actor actor);
}