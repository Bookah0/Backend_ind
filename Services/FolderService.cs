using System.Threading.Tasks;
using Backend_ind.Interfaces;
using Backend_ind.Models;

namespace Backend_ind.Services;

public class FolderService : EfService<FolderEntity>
{
    public async Task AddFromRequest(Guid userId, Guid folderId, CreateFolderRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.name))
        {
            throw new Exception("Folder must have a name");
        }

        var folder = new FolderEntity
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            FolderId = folderId,
            Name = request.name,
        };

        await repository.AddAsync(folder);
    }
}