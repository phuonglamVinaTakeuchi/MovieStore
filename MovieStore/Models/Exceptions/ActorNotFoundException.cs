namespace MovieStore.Models.Exceptions
{
  public class ActorNotFoundException : NotFoundException
  {
    public ActorNotFoundException(int id) : base($"The actor with id: {id} doesn't exist in the database.")
    {
    }
  }
}
