﻿using System.Linq.Expressions;
using MovieStore.Models.Entities;

namespace MovieStore.Data.Repositories;

public interface IRepositoryBase <T> where T: class,IEntityBase,new()
{
  IQueryable<T> FindAll(bool trackChanges);
  IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
  bool trackChanges);
  void Create(T entity);
  void Update(T entity);
  void Delete(T entity);
}