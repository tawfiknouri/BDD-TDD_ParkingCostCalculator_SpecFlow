using BoDi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using ParkCostCalc.Core.Infrastructure;
using ParkCostCalc.Core.Infrastructure.Repositories;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Services;
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

            var emailService = new Mock<IEmailService>();
            emailService.Setup(mock => mock.SendEmailToSupport(It.IsAny<Contact>())).Returns(true);
            _objectContainer.RegisterInstanceAs(emailService.Object, typeof(IEmailService));
        }

    }
}
