using Microsoft.AspNetCore.Authorization;
using testasp.Repositories;

namespace testasp.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;
    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    [HttpGet]
    [Authorize]
    public async Task<List<string>> Get()
    {
        return await _userRepository.GetUserNames();
    }
}