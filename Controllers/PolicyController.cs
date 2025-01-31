using Microsoft.AspNetCore.Mvc;

namespace PolicyCustomerService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PolicyCustomerService.Interface;
    using PolicyCustomerService.Request;
    using System.Threading.Tasks;

    // Handles incoming HTTP requests
    [ApiController]
    [Route("api/[controller]")]
    public class PolicyController : ControllerBase
    {
        private readonly IPolicyCommand _policyCommand; // Injected as an interface

        public PolicyController(IPolicyCommand policyCommand)
        {
            _policyCommand = policyCommand; // Dependency injection
        }

        [HttpPost]
        public async Task<IActionResult> CreatePolicy([FromBody] PolicyRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid request.");
            }

            var result = await _policyCommand.ExecuteAsync(request);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
    }

}
