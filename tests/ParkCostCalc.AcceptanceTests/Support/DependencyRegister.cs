using System;
using BoDi;
using Microsoft.Extensions.Logging;
using Moq;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;

using ParkCostCalc.Core.Specs.Drivers.CostCalculator;

namespace ParkCostCalc.AcceptanceTests.Support
{
    public class DependencyRegister
    {
        public static void RegisterDependencies(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new LoggerFactory(), typeof(ILoggerFactory));
            var emailService = new Mock<IEmailService>();
            emailService.Setup(mock => mock.SendEmailToSupport(It.IsAny<Contact>())).Returns(true);
            objectContainer.RegisterInstanceAs(emailService.Object, typeof(IEmailService));
            objectContainer.RegisterTypeAs<CostCalculatorApiDriver, ICostCalculatorDriver>();

        }
    }
}
