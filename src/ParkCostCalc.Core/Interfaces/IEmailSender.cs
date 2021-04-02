using ParkCostCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkCostCalc.Core.Interfaces
{
    public interface IEmailSender
    {
        bool SendEmailToSupport(string to, string from, string subject, string body);
    }
}
