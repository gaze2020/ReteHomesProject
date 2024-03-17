using NUnit.Framework;
using OpenQA.Selenium;
using ReteHomesProject.Hooks;
using ReteHomesProject.RetePageObjects;
using System;
using TechTalk.SpecFlow;

namespace ReteHomesProject.StepDefinitions
{
    [Binding]
    class LoginStepDefinition
    {
        public IWebDriver driver = ReteWebHooks.driver;
        LoginPage login = new LoginPage();

        [Given(@"I am on the homepage of the Retehomes website")]
        public void GivenIAmOnTheHomepageOfTheRetehomesWebsite()
        {
            driver.Url = ("https://propertyretehomes.reteicons.com/");
        }

        [When(@"I click the Login Button on the header section")]
        public void WhenIClickTheLoginButtonOnTheHeaderSection()
        {
            login.ClickLoginButton();
        }

        [When(@"I enter a valid registered email address")]
        public void WhenIEnterAValidRegisteredEmailAddress()
        {
            login.EnterUsernameOrEmai();
        }

        [When(@"I enter a valid registered password")]
        public void WhenIEnterAValidRegisteredPassword()
        {
            login.EnterPassword();
        }

        [When(@"I checked the Remember Me box")]
        public void WhenICheckedTheRememberMeBox()
        {
            login.CheckRememberMeBox();
        }

        [When(@"I click on the Login Button")]
        public void WhenIClickOnTheLoginButton()
        {
            login.ClickLoginSubmitButton();
        //    Thread.Sleep(3000);
        //    login.ClickMyProfileButton();
        //    Thread.Sleep(3000);
        //    login.ClickMyProfileButton();
        //    Thread.Sleep(3000);
        //    login.ClickUpdateProfileButton();
        //
        }

        [Then(@"I should be successfullly logged in to my profile")]
         public void ThenIShouldBeSuccessfulllyLoggedInToMyProfile()
        {
            
                
        }
    }
}
