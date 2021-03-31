using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Interfaces
{
    public interface IContactRepository
    {
        Contact CreateContact(Contact contact);
    }
}
