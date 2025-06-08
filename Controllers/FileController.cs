using System.Security.Claims;
using Backend_ind.Models;
using Backend_ind.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("file")]
public class FileController : ControllerBase
{
    private readonly FileService fileService;
    private readonly ILogger<FileController> logger;

    public FileController(FileService fileService, ILogger<FileController> logger)
    {
        this.fileService = fileService;
        this.logger = logger;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateFile([FromBody] UploadFileRequest request)
    {
        try
        {
            await fileService.AddFromRequest(request);   
            return Ok(); 
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFile(Guid id)
    {
        try
        {
            var file = await fileService.GetAsync(id);
            return Ok(file);    
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteFile(Guid id)
    {
        try
        {
            await fileService.DeleteAsync(id);
            return Ok(); 
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }
}
