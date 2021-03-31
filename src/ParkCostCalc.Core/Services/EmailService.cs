using ParkCostCalc.Application.Helpers;
using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;

namespace ParkCostCalc.Application.Services
{
    public class EmailService : IEmailService
    {
        public bool SendEmailToSupport(Contact contact)
        {
            return EmailHelper.SendEmailToSupport(contact.Email, contact.Subject, contact.Message, contact.Name);
        }
    }
}
