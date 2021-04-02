using ParkCostCalc.Core.Interfaces;

namespace ParkCostCalc.Infrastructure
{
    public class EmailSender : IEmailSender
    {
        public bool SendEmailToSupport(string to, string from, string subject, string body)
        {
            //throw new NotImplementedException();
            return true;
        }
    }
}
