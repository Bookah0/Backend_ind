namespace Backend_ind.Models;

public class FileEntity
{
    public required Guid Id { get; set; }
    public required Guid FolderId { get; set; }
    public required Guid UserId { get; set; }
    public required string Name { get; set; }
    public string? Content { get; set; }
}