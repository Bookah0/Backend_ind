using Backend_ind.Data;
using Backend_ind.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend_ind.Repositories;

public class EfPostRepository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext context;

    public EfPostRepository(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<T> AddAsync(T toCreate)
    {
        await context.Set<T>().AddAsync(toCreate);
        await context.SaveChangesAsync();
        return toCreate;
    }

    public async Task<T> DeleteAsync(T entityToRemove)
    {
        context.Set<T>().Remove(entityToRemove);
        await context.SaveChangesAsync();
        return entityToRemove;
    }

    public async Task<T> GetAsync(Guid id)
    {
        var item = await context.Set<T>().FindAsync(id);
        return item;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task UpdateAsync(T updatedEntity)
    {
        context.Set<T>().Update(updatedEntity);
        await context.SaveChangesAsync();
    }
}