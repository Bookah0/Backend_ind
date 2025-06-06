using Backend_ind.Models;
using Backend_ind.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("folder")]
public class FolderController : Controller
{
    private readonly FolderService folderService;
    private readonly ILogger<FolderController> logger;

    public FolderController(FolderService folderService, ILogger<FolderController> logger)
    {
        this.folderService = folderService;
        this.logger = logger;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateFolder([FromBody] CreateFolderRequest request)
    {
        try
        {
            await folderService.AddFromRequest(request);
            return Ok();
        }
        catch (Exception)
        {
            throw;
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFolder(Guid id)
    {
        try
        {
            var folder = await folderService.GetAsync(id);
            return Ok(folder);
        }
        catch (Exception)
        {
            throw;
        }
    }
}

public class CreateFolderRequest()
{
    public required string name { get; set; }
}
