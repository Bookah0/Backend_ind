namespace Backend_ind.Models;

public class FolderEntity
{
    public required Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Guid FolderId { get; set; }
    public required string Name { get; set; }
}