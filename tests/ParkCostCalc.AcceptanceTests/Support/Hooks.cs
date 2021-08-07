using System;
using BoDi;
using Microsoft.EntityFrameworkCore;
using ParkCostCalc.AcceptanceTests.Support;
using ParkCostCalc.Core.Infrastructure;
using ParkCostCalc.Core.Infrastructure.Repositories;
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
            DependencyRegister.RegisterDependencies(_objectContainer);
        }

    }
}
