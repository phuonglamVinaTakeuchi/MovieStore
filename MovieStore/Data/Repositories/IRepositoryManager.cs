namespace MovieStore.Data.Repositories;

public interface IRepositoryManager
{
  IActorRepository ActorRepository { get; }
  Task SaveAsync();
}