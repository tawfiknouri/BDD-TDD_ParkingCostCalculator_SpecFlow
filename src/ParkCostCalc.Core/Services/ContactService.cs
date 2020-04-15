using ParkCostCalc.Core.Infrastructure.Repositories;
using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Services
{
    public class ContactService: IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contact CreateContact(Contact contact )
        {
            return _contactRepository.CreateContact(contact);
        }
    }
}
