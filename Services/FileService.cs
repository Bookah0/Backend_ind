using System.Threading.Tasks;
using Backend_ind.Interfaces;
using Backend_ind.Models;
using Microsoft.AspNetCore.Identity;

namespace Backend_ind.Services;

public class FileService : EfService<FileEntity>
{
    private readonly FolderService folderService;
    
    public FileService(IRepository<FileEntity> repository, FolderService folderService)
    {
        this.repository = repository;
        this.folderService = folderService;
    }

    public async Task AddFromRequest(UploadFileRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new Exception("File must have a name");

        if (!Guid.TryParse(request.FolderId, out var folderId))
            throw new Exception("Invalid GUID format");

        if (folderId == Guid.Empty)
        {
            folderId = folderService.GetOpenedFolder();
        }

        var file = new FileEntity
        {
            Id = Guid.NewGuid(),
            UserId = Guid.Empty,
            FolderId = folderId,
            Name = request.Name,
            Content = request.Content
        };

        await repository.AddAsync(file);
    }
}