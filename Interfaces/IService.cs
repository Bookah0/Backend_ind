namespace Backend_ind.Interfaces;

public interface IService<T>
{
    public Task AddAsync(T entityToAdd);
    public Task<T> GetAsync(Guid id);
    public Task<IEnumerable<T>> GetAllAsync();
    public Task UpdateAsync(T entityToUpdate);
    public Task DeleteAsync(T entityToRemove);
    public Task DeleteAsync(Guid id);
}