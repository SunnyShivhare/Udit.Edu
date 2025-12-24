using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UditEdu.Application.Queries;

namespace UditEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalVendorController(ISender sender) : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetNationalizeData()
        {
            var result = await sender.Send(new GetNationalizeDataQuery());
            return Ok(result);
        }

        [HttpGet("joke")]
        public async Task<IActionResult> GetJokeData()
        {
            var result = await sender.Send(new GetJokeDataQuery());
            return Ok(result);
        }
    }
}
