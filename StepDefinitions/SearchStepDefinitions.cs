using OpenQA.Selenium;
using ReteHomesProject.Hooks;
using System;
using TechTalk.SpecFlow;

namespace ReteHomesProject.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = ReteWebHooks.driver;
       

        [Given(@"that I am on the landing page of ReteHomes Property Website")]
        public void GivenThatIAmOnTheLandingPageOfReteHomesPropertyWebsite()
        {
            driver.Url = "https://propertyretehomes.reteicons.com/";
            Thread.Sleep(3000);
        }

        [Given(@"I scroll down to the search button")]
        public void GivenIScrollDownToTheSearchButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0, -500)");
        }

        [When(@"I click on the search field")]
        public void WhenIClickOnTheSearchField()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("input[placeholder='Enter Keyword...']")).Click();
           // driver.FindElement("//*[@id=\"desktop-header-search\"]/div/form/div[1]/div/div[1]/div/div/input").SendKeys("Lagos Property");
        }

        [When(@"I type Lagos Property on the search field")]
        public void WhenITypeLagosPropertyOnTheSearchField()
        {
            driver.FindElement(By.CssSelector("input[placeholder='Enter Keyword...']")).SendKeys("Lagos Property");
        }

        [When(@"I click on the search button")]
        public void WhenIClickOnTheSearchButton()
        {
            driver.FindElement(By.CssSelector("button[class='btn btn-search btn-secondary btn-full-width ']")).Click();
        }

        [Then(@"I am redirected to a detailed page of the searched property")]
        public void ThenIAmRedirectedToADetailedPageOfTheSearchedProperty()
        {
           
        }
    }
}
