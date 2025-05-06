
using System.Threading.Tasks;
using Backend_ind.Interfaces;

namespace Backend_ind.Services;

public class EfService<T> : IService<T>
{
    private readonly IRepository<T> repository;

    public async void Add(T entityToAdd)
    {
        await repository.AddAsync(entityToAdd);
    }

    public async void Delete(T entityToRemove)
    {
        await repository.DeleteAsync(entityToRemove);
    }

    public async Task<T> Get(Guid id)
    {
        return await repository.GetAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await repository.GetAllAsync();
    }

    public async void Update(T entityToUpdate)
    {
        await repository.UpdateAsync(entityToUpdate);
    }
}