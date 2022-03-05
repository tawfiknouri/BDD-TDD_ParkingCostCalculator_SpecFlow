using System;
using ParkCostCalc.AcceptanceTests.Helpers;
using ParkCostCalc.AcceptanceTests.Models;
using RestSharp;
using RestSharp.Serialization.Json;

namespace ParkCostCalc.AcceptanceTests.Drivers.CostCalculator
{
    public class CostCalculatorApiDriver : ICostCalculatorDriver
    {
        public decimal CalculateCost(ParkTypeEnum parkingType, string duration)
        {
            var apiBaseUrl = "https://webpark-api.herokuapp.com";
            var requestUrl = "/CostCalculator";

            var totalMinutes = Parser.ParseDuration(duration);
            DateTime entryDate = DateTime.Now;
            DateTime exitDate = entryDate.AddMinutes(totalMinutes);

            var requestData = new
            {
                parkType = parkingType.ToString(),
                entryDate = entryDate,
                exitDate = exitDate
            };

            var restClient = new RestClient(apiBaseUrl);
            var request = new RestRequest(requestUrl, Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddJsonBody(requestData);
            request.Timeout = 600000;
            var response = restClient.Execute(request);
            CostResponse costResponse = new JsonDeserializer().Deserialize<CostResponse>(response);
            return Decimal.Parse(costResponse.Cost);
        }
    }
}