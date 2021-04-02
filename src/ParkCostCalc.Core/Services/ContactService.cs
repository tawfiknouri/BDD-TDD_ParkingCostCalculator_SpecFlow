using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Services
{
    public class ContactService: IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IEmailSender _emailSender;
        public ContactService(IContactRepository contactRepository,  IEmailSender emailSender)
        {
            _contactRepository = contactRepository;
            _emailSender = emailSender;
        }
        public Contact ContactUs(Contact contact )
        {
            var dbContact = _contactRepository.CreateContact(contact);

            _emailSender.SendEmailToSupport("support@webpark.com", dbContact.Email, "support", contact.Message);

            return dbContact;

        }
    }
}
