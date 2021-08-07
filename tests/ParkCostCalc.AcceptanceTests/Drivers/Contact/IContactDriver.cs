
using ParkCostCalc.Core.Specs.Models;

namespace ParkCostCalc.Core.Specs.Drivers.CostCalculator
{
     public interface IContactDriver
    {
        public Contact AddContactDetails(Contact contact);
        public bool SendEmail(Contact contact);

    }
}