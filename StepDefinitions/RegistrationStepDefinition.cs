using NUnit.Framework;
using OpenQA.Selenium;
using ReteHomesProject.Hooks;
using ReteHomesProject.RetePageObjects;
using System;
using TechTalk.SpecFlow;

namespace ReteHomesProject.StepDefinitions
{
    [Binding]
    class RegistrationStepDefinition
    {
        public IWebDriver driver = ReteWebHooks.driver;
        RegistrationPage register = new RegistrationPage();

        [Given(@"I am on the ReteHomes Property Website")]
        public void GivenIAmOnTheReteHomesPropertyWebsite()
        {
            driver.Url = ("https://propertyretehomes.reteicons.com/");
        }

        [When(@"I click on the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            register.ClickRegisterButton();
            Thread.Sleep(2000);
        }

        [When(@"I enter my full names")]
        public void WhenIEnterMyFullNames()
        {
            register.EnterFirstname();
            register.EnterLastname();
            Thread.Sleep(2000);

        }

        [When(@"I enter a unique username")]
        public void WhenIEnterAUniqueUsername()
        {
            register.EnterUsername();
            Thread.Sleep(2000);
        }

        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            register.EnterEmail();
            Thread.Sleep(2000);
        }

        [When(@"I enter a valid phone number")]
        public void WhenIEnterAValidPhoneNumber()
        {
            register.EnterPhoneNumber();
            Thread.Sleep(2000);
        }

        [When(@"I enter my password and re-type the password")]
        public void WhenIEnterMyPasswordAndRe_TypeThePassword()
        {
            register.EnterPassword();
            register.EnterRetypePassword();
            Thread.Sleep(2000);
        }

        [When(@"I select seller from the dropdown")]
        public void WhenISelectSellerFromTheDropdown()
        {
            register.ClickDropdownButton();
            register.ClickSellerOption();
            Thread.Sleep(2000);
        }

        [When(@"I checked the box for T&C agreement")]
        public void WhenICheckedTheBoxForTCAgreement()
        {
            register.CheckTandCBox();
            Thread.Sleep(2000);
        }

        [When(@"I click on the Register2 button")]
        public void WhenIClickOnTheRegister2Button()
        {
            register.ClickRegistrationButton();
            Thread.Sleep(2000);
        }

        [Then(@"I am registered as a seller on the website with email confirmation")]
        public void ThenIAmRegisteredAsASellerOnTheWebsiteWithEmailConfirmation()
        {
            
        }
    }
}
