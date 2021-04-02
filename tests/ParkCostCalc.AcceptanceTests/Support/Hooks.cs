using BoDi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using ParkCostCalc.Core.Interfaces;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Infrastructure.Data;
using ParkCostCalc.Infrastructure.Data.Repositories;
using TechTalk.SpecFlow;

namespace ParkCostCalc.Core.Specs.Support
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario("db")]
        public void InitializeDataBaseDependencies()
        {
            var options = new DbContextOptionsBuilder<ParkingDbContext>()
               .UseInMemoryDatabase(databaseName: "BDDParking")
               .Options;

            _objectContainer.RegisterInstanceAs(new ParkingDbContext(options), typeof(ParkingDbContext));
            _objectContainer.RegisterTypeAs<ContactRepository, IContactRepository>();
        }

        [BeforeScenario]
        public void InitializeDependencies()
        {
            _objectContainer.RegisterInstanceAs(new LoggerFactory(), typeof(ILoggerFactory));

            var emailSender = new Mock<IEmailSender>();
            emailSender.Setup(mock => mock.SendEmailToSupport(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            _objectContainer.RegisterInstanceAs(emailSender.Object, typeof(IEmailSender));
        }

    }
}
