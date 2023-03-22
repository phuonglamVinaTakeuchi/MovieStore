using AutoMapper;
using MovieStore.Data.Repositories;
using MovieStore.Models.Entities;
using MovieStore.Models.Exceptions;

namespace MovieStore.Data.Services
{
  public abstract class ServiceBase <TRepository,TEntityViewModel,TEntity> : IServiceBase<TEntityViewModel>
    where TRepository: IRepositoryBase<TEntity>
    where TEntity: class,IEntityBase
  {
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper; 

    protected IRepositoryManager RepositoryManager => _repositoryManager;

    protected ServiceBase(IRepositoryManager repositoryManager, IMapper mapper)
    {
      _repositoryManager = repositoryManager;
      _mapper = mapper;
    }
    public async Task<IEnumerable<TEntityViewModel>> GetAllAsync(bool trackChanges)
    {
      var repository = RepositoryManager.GetRepository<TRepository,TEntity>();
      var entities = await repository.GetAllAsync(trackChanges);
      var entityViewModels = _mapper.Map<IEnumerable<TEntityViewModel>>(source: entities);

      return entityViewModels;
    }

    public async Task<TEntityViewModel?> GetByIdAsync(int id, bool trackChanges)
    {
      var repository = RepositoryManager.GetRepository<TRepository,TEntity>();
      var entity = await repository.GetByIdAsync(id,trackChanges);
      var entityViewModel = _mapper.Map<TEntityViewModel>(source:entity);

      return entityViewModel;

    }

    public async Task AddAsync(TEntityViewModel entityForCreation)
    {
      var repository = RepositoryManager.GetRepository<TRepository, TEntity>();

      var entity = _mapper.Map<TEntity>(source:entityForCreation);

      await repository.CreateEntity(entity);
      await _repositoryManager.SaveAsync();
    }

    public async Task UpdateAsync(int id, TEntityViewModel entityForUpdate)
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
        throw NotFoundExceptionFactory.Create<TEntityViewModel>(id);
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
