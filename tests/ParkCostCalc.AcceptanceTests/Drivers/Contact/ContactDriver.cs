
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Core.Specs.Drivers.CostCalculator
{
    public class ContactDriver: IContactDriver
    {
        private readonly IContactService _contactService;
        private readonly IEmailService _emailService;

        public ContactDriver(ContactService contactService, IEmailService emailService)
        {
            _contactService = contactService;
            _emailService = emailService;
        }

        /*public Contact AddContactDetails(Contact contact)
        {
            return _contactService.CreateContact(contact);
        }*/

        public Models.Contact AddContactDetails(Models.Contact contact)
        {
            throw new System.NotImplementedException();
        }

        /*public bool SendEmail(Contact contact)
        {
            return _emailService.SendEmailToSupport(contact);
        }*/

        public bool SendEmail(Models.Contact contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
