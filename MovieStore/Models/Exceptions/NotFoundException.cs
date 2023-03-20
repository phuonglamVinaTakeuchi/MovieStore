﻿namespace MovieStore.Models.Exceptions
{
  public abstract class NotFoundException : Exception
  {
    protected NotFoundException(string message) : base(message)
    { }
  }
}
