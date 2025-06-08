public class UploadFileRequest
{
    public required string Name { get; set; }
    public required string Content { get; set; }
    public string? FolderId { get; set; }
}