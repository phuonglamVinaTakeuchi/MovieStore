using MovieStore.Models.Entities;

namespace MovieStore.Data.Services;

public interface IActorService
{
  Task<IEnumerable<Actor>> GetAllAsync(bool trackChanges);
  Task<Actor?> GetByIdAsync(int id, bool trackChanges);
  Task AddAsync(Actor actor);
  Task UpdateAsync(int id, Actor newActor, bool trackChanges);
  Task DeleteAsync(int id);
}