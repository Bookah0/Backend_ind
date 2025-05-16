using Backend_ind.Models;
using Backend_ind.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly EfService<UserEntity> userService;
    private readonly ILogger<FolderController> logger;

    public UserController(EfService<UserEntity> userService, ILogger<FolderController> logger)
    {
        this.userService = userService;
        this.logger = logger;
    }

    [HttpPost("create")]
    public async Task<IActionResult> RegisterUser([FromBody] CreateFolderRequest request)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        throw new NotImplementedException();
    }
}
