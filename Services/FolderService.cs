using System.Threading.Tasks;
using Backend_ind.Interfaces;
using Backend_ind.Models;
using Microsoft.AspNetCore.Identity;

namespace Backend_ind.Services;

public class FolderService : EfService<FolderEntity>
{
    public FolderService(IRepository<FolderEntity> repository)
    {
        this.repository = repository;
    }

    public Guid openedFolderId;

    public async Task AddFromRequest(CreateFolderRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new Exception("Folder must have a name");

        if (!Guid.TryParse(request.SuperFolderId, out var folderId))
            throw new Exception("Invalid GUID format");

        if (folderId == Guid.Empty)
        {
            folderId = openedFolderId;
        }


        var folder = new FolderEntity
        {
            Id = Guid.NewGuid(),
            UserId = Guid.Empty,
            FolderId = folderId,
            Name = request.Name,
        };

        await repository.AddAsync(folder);
    }

    public void OpenFoler(Guid folderId)
    {
        openedFolderId = folderId;
    }

    public Guid GetOpenedFolder()
    {
        return openedFolderId;
    }

}