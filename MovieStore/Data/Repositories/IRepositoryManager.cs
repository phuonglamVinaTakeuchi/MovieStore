using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public interface IRepositoryManager
{
  IActorRepository ActorRepository { get; }

  TRepository GetRepository<TRepository, TEntity>()
    where TRepository : IRepositoryBase<TEntity>;

  Task SaveAsync();
}