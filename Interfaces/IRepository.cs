namespace Backend_ind.Interfaces;

public interface IRepository<T>
{
    public Task<T> AddAsync(T toCreate);
    public Task<T> GetAsync(Guid id);
    public Task<IEnumerable<T>> GetAllAsync();
    public Task UpdateAsync(T updatedEntity);
    public Task<T> DeleteAsync(T entityToRemove);    
}