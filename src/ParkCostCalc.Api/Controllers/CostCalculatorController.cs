using Microsoft.AspNetCore.Mvc;
using ParkCostCalc.Api.ApiModels;
using ParkCostCalc.Core.Interfaces;


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

            var duration = (parkRequest.ExitDate - parkRequest.EntryDate).Value;
            var costDetails = _costService.CalculateCost(parkRequest.ParkType.Value, duration.TotalMinutes);
            return Ok(costDetails);
        }
    }
}
