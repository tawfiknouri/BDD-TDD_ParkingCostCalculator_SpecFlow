using Microsoft.AspNetCore.Mvc;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CostCalculatorController : ControllerBase
    {
        private readonly IParkCostCalcService _costService;

        public CostCalculatorController(IParkCostCalcService costService)
        {
            _costService = costService;
        }

        [HttpPost]
        public IActionResult GetCost([FromBody] ParkRequest parkRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if ((parkRequest.ExitDate - parkRequest.EntryDate).Value.TotalMinutes < 0)
            {
                return BadRequest("Entry date time cannot be less than exit date time!");
            }
            var costDetails = _costService.CalculateCost(parkRequest);
            return Ok(costDetails);
        }
    }
}
