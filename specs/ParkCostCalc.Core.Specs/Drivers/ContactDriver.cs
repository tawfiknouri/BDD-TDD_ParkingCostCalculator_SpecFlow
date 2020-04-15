using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Core.Specs.Drivers
{
    public class ContactDriver
    {
        private readonly IContactService _contactService;
        private readonly IEmailService _emailService;

        public ContactDriver(ContactService contactService, IEmailService emailService)
        {
            _contactService = contactService;
            _emailService = emailService;
        }

        public Contact AddContactDetails(Contact contact)
        {
            return _contactService.CreateContact(contact);
        }
        public bool SendEmail(Contact contact)
        {
            return _emailService.SendEmailToSupport(contact);
        }
    }
}
