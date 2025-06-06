
using System.Threading.Tasks;
using Backend_ind.Interfaces;

namespace Backend_ind.Services;

public class EfService<T> : IService<T>
{
    protected readonly IRepository<T> repository;

    public async Task AddAsync(T entityToAdd)
    {
        await repository.AddAsync(entityToAdd);
    }

    public async Task DeleteAsync(T entityToRemove)
    {
        await repository.DeleteAsync(entityToRemove);
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetAsync(id);
        await repository.DeleteAsync(entity);
    }

    public async Task<T> GetAsync(Guid id)
    {
        return await repository.GetAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await repository.GetAllAsync();
    }

    public async Task UpdateAsync(T entityToUpdate)
    {
        await repository.UpdateAsync(entityToUpdate);
    }
}