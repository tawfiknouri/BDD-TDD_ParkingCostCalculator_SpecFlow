using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Infrastructure.Repositories
{
    public interface IContactRepository
    {
        Contact CreateContact(Contact contact);
    }
}
