using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Locations.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "America", "Bangladesh", "Canada" };
        }
    }
}
