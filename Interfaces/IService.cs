namespace Backend_ind.Interfaces;

public interface IService<T>
{
    public void Add(T entityToAdd);
    public Task<T> Get(Guid id);
    public Task<IEnumerable<T>> GetAll();
    public void Update(T entityToUpdate);
    public void Delete(T entityToRemove);
}