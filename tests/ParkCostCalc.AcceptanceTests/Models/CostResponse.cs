using Newtonsoft.Json;

namespace ParkCostCalc.AcceptanceTests.Models
{
    public class CostResponse
    {
       [JsonProperty("cost")]
        public string Cost {get; set;}
    }
}