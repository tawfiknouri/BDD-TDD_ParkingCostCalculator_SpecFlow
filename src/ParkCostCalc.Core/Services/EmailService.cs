using ParkCostCalc.Core.Helpers;
using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Core.Services
{
    public class EmailService : IEmailService
    {
        public bool SendEmailToSupport(Contact contact)
        {
            return EmailHelper.SendEmailToSupport(contact.Email, contact.Subject, contact.Message, contact.Name);
        }
    }
}
