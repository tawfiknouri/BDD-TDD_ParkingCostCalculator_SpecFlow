﻿using NUnit.Framework;
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
        private Contact _contactDetails;
        private readonly ContactDriver _contactDriver;
        private readonly ScenarioContext _scenarioContext;

        public ContactSteps(ScenarioContext scenarioContext, Contact contactDetails, ContactDriver contactDriver)
        {
            _scenarioContext = scenarioContext;
            _contactDetails = contactDetails;
            _contactDriver = contactDriver;
        }

        [Given(@"the following contact details")]
        public void GivenTheFollowingContactDetails(Table table)
        {
            _contactDetails = table.CreateInstance<Contact>();
        }

        [When(@"the contact request is submitted")]
        public void WhenTheContactRequestIsSubmitted()
        {
            // Adding Contact
            _contactDetails = _contactDriver.AddContactDetails(_contactDetails);

            // Sending Email
            var emailSentStatus = _contactDriver.SendEmail(_contactDetails);
            _scenarioContext.Add("emailSentStatus", emailSentStatus);
        }

        [Then(@"the contact request should be created successfully")]
        public void ThenTheContactRequestShouldBeCreatedSuccessfully()
        {
            Assert.IsTrue(_contactDetails.Id > 0, "Error during adding contact!");
        }

        [Then(@"the email with contact request should be sent to the support team")]
        public void ThenTheEmailWithContactRequestShouldBeSentToTheSupportTeam()
        {
            _scenarioContext.TryGetValue("emailSentStatus", out bool emailSentStatus);
            Assert.IsTrue(emailSentStatus, "Error during sending email!");
        }

    }
}
