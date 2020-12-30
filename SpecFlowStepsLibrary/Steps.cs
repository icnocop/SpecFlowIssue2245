using BoDi;
using TechTalk.SpecFlow;

namespace SpecFlowStepsLibrary
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IObjectContainer objectContainer;

        public StepDefinitions(ScenarioContext scenarioContext, IObjectContainer objectContainer)
        {
            this.scenarioContext = scenarioContext;
            this.objectContainer = objectContainer;
        }

        [Given(@"this is a step in another assembly")]
        public void GivenThisIsAStepInAnotherAssembly()
        {
            scenarioContext.Pending();
        }
    }
}
