namespace MovieStore.Models.Exceptions
{
  public static class NotFoundExceptionFactory
  {
    public static NotFoundException Create<TEntity>(int id)
    {
      throw new NotImplementedException();
    }
  }
}
