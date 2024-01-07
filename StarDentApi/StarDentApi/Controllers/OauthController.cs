using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarDentApi.Repositories.Abstract;
using StarDentApi.Repositories.Concrete;

namespace StarDentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "test,test1")]
    public class OauthController : ControllerBase
    {
        private readonly IAccesstokenRepository accesstokenRepository;
        public OauthController(IAccesstokenRepository _accesstokenRepository) 
        {
            accesstokenRepository = _accesstokenRepository;
        }

        public IActionResult Test()
        {

            return Ok();
        }
    }
}
