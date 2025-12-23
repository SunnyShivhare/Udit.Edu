using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UditEdu.Application.Commands;
using UditEdu.Application.Queries;
using UditEdu.Core.Entities;

namespace UditEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody] EmployeeEntity employeeEntity)
        {
            var result = await sender.Send(new AddEmployeeCommand(employeeEntity));
            return Ok(result);
        }

        [HttpGet("employees")]
        public async Task<IActionResult> GetAllEmployeeAsync()
        {
            var result = await sender.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }

        [HttpGet("Employees/{employeeId}")]
        public async Task<IActionResult> GetEmployeeByEmployeeId([FromRoute]Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }

        [HttpPut("Employees/{employeeId}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute]Guid employeeId, [FromBody]EmployeeEntity employeeEntity) 
        { 
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId, employeeEntity));
            return Ok(result);
        }

        [HttpDelete("Employees/{employeeId}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            return Ok(result);
        }
    }
}
