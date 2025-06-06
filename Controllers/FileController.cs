using Backend_ind.Models;
using Backend_ind.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("folder")]
public class FileController : Controller
{
    private readonly EfService<FileEntity> fileService;
    private readonly ILogger<FileController> logger;

    public FileController(EfService<FileEntity> folderService, ILogger<FileController> logger)
    {
        this.fileService = folderService;
        this.logger = logger;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateFile([FromBody] CreateFileRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFile(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteFile(Guid id)
    {
        throw new NotImplementedException();
    }
}

public class CreateFileRequest
{

}
