using AutoMapper;
using BookstoreApp.API.Data;
using BookstoreApp.API.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly IMapper mapper;
        private readonly UserManager<ApiUser> userManager;

        public AuthController(ILogger<AuthController> logger, IMapper mapper, UserManager<ApiUser> userManager)
        {
            this.logger = logger;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            var user = mapper.Map<ApiUser>(userDto);
            var result = await userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded == false)
            { 
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
        }
    }
}
