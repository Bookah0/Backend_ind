using Backend_ind.Models;
using Backend_ind.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("folder")]
public class FolderController : Controller
{
    private readonly EfService<FolderEntity> folderService;
    private readonly ILogger<FolderController> logger;

    public FolderController(EfService<FolderEntity> folderService, ILogger<FolderController> logger)
    {
        this.folderService = folderService;
        this.logger = logger;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateFolder([FromBody] CreateFolderRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFolder(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteFolder(Guid id)
    {
        throw new NotImplementedException();
    }
}

public class CreateFolderRequest()
{

}
