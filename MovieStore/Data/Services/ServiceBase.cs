using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.Exceptions;

namespace MovieStore.Data.Services
{
  public abstract class ServiceBase <TRepository,TEntity> : IServiceBase<TEntity>
    where TRepository : IRepositoryBase<TEntity>
    where TEntity : class,IEntityBase,new()
  {
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper; 

    protected IRepositoryManager RepositoryManager => _repositoryManager;

    protected ServiceBase(IRepositoryManager repositoryManager, IMapper mapper)
    {
      _repositoryManager = repositoryManager;
      _mapper = mapper;
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync(bool trackChanges)
    {
      var repository = RepositoryManager.GetRepository<TRepository,TEntity>();
      return await repository.GetAllAsync(trackChanges);
    }

    public async Task<TEntity?> GetByIdAsync(int id, bool trackChanges)
    {
      var repository = RepositoryManager.GetRepository<TRepository,TEntity>();
      return await repository.GetByIdAsync(id,trackChanges);
    }

    public async Task AddAsync(TEntity entity)
    {
      var repository = RepositoryManager.GetRepository<TRepository, TEntity>();
      await repository.CreateEntity(entity);
      await _repositoryManager.SaveAsync();
    }

    public async Task UpdateAsync(int id, TEntity entityForUpdate)
    {
      var entity = await GetEntityAndCheckIfItExist(id, true);

      _mapper.Map(entityForUpdate, entity);

      await _repositoryManager.SaveAsync();
    }

    protected async Task<TEntity> GetEntityAndCheckIfItExist(int id, bool trackChanges = false)
    {
      var repository = RepositoryManager.GetRepository<TRepository, TEntity>();

      var entity = await repository.GetByIdAsync(id, trackChanges);

      if (entity is null)
      {
        throw NotFoundExceptionFactory.Create<TEntity>(id);
      }

      return entity;
    }

    public async Task DeleteAsync(int id)
    {
      var entity = await GetEntityAndCheckIfItExist(id);
      var repository = RepositoryManager.GetRepository<TRepository, TEntity>();
      repository.DeleteAsync(entity);
      await _repositoryManager.SaveAsync();
    }
  }
}
