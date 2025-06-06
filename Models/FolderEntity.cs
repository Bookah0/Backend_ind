namespace Backend_ind.Models;

public class FolderEntity
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public Guid? SuperFolderId { get; set; }
    public required string Name { get; set; }
    public ICollection<FolderEntity> Subfolders { get; set; } = [];
    public ICollection<FileEntity> Files { get; set; } = [];

}