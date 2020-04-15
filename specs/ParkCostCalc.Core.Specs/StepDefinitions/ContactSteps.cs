using NUnit.Framework;
using ParkCostCalc.Core.Models;
using ParkCostCalc.Core.Specs.Drivers;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ParkCostCalc.Core.Specs.StepDefinitions
{
    [Binding]
    public class ContactSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ContactDriver _contactDriver;

        public ContactSteps(ScenarioContext scenarioContext, ContactDriver contactDriver)
        {
            _scenarioContext = scenarioContext;
            _contactDriver = contactDriver;
        }

        [Given(@"the following contact details")]
        public void GivenTheFollowingContactDetails(Table table)
        {
            var contactDetails = table.CreateInstance<Contact>();
            _scenarioContext.Add("contactDetails", contactDetails);

        }

        [When(@"the contact request is submited")]
        public void WhenTheContactRequestIsSubmited()
        {
            // Adding Contact
            _scenarioContext.TryGetValue("contactDetails", out Contact contactDetails);
            var dbContactDetails = _contactDriver.AddContactDetails(contactDetails);
            _scenarioContext.Add("dbContactDetails", dbContactDetails);

            // Sending Email
            var emailSentStatus = _contactDriver.SendEmail(contactDetails);
            _scenarioContext.Add("emailSentStatus", emailSentStatus);
        }

        [Then(@"the contact request should be created successfully")]
        public void ThenTheContactRequestShouldBeCreatedSuccessfully()
        {
            _scenarioContext.TryGetValue("dbContactDetails", out Contact dbContactDetails);
            Assert.IsTrue(dbContactDetails.Id > 0, "Error during adding contact!");
        }

        [Then(@"the email with contact request should be sent to the support team")]
        public void ThenTheEmailWithContactRequestShouldBeSentToTheSupportTeam()
        {
            _scenarioContext.TryGetValue("emailSentStatus", out bool emailSentStatus);
            Assert.IsTrue(emailSentStatus, "Error during sending email!");
        }

    }
}
