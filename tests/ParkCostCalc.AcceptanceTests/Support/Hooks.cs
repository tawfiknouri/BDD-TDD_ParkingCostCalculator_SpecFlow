using BoDi;
using TechTalk.SpecFlow;

namespace ParkCostCalc.AcceptanceTests.Support
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
            // todo: setup data for acceptance tests
        }

        [BeforeScenario]
        public void InitializeDependencies()
        {
            DependencyRegister.RegisterDependencies(_objectContainer);
        }

    }
}
