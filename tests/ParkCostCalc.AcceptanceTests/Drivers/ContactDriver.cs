

using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

namespace ParkCostCalc.Core.Specs.Drivers
{
    public class ContactDriver
    {
        private readonly IContactService _contactService;
        private readonly IEmailSender _emailSender;

        public ContactDriver(ContactService contactService, IEmailSender emailSender)
        {
            _contactService = contactService;
            _emailSender = emailSender;
        }

        public Contact AddContactDetails(Contact contact)
        {
            return _contactService.ContactUs(contact);
        }
        public bool SendEmail(Contact contact)
        {
            return _emailSender.SendEmailToSupport("support@webpark.com", contact.Email, "support", contact.Message);
        }
    }
}
