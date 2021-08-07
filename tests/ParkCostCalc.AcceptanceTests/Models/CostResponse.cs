using Newtonsoft.Json;
namespace ParkCostCalc.Core.Specs.Models
{
    public class CostResponse
    {
       [JsonProperty("cost")]
        public string Cost {get; set;}
    }
}