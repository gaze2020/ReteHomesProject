using OpenQA.Selenium;
using ReteHomesProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteHomesProject.RetePageObjects
{
    class RegistrationPage
    {
        public IWebDriver driver;
        public RegistrationPage()
        {
            driver = ReteWebHooks.driver;
        }


        private By RegisterButton = By.CssSelector("body > main:nth-child(2) > header:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > ul:nth-child(1) > li:nth-child(2) > a:nth-child(1)");
        private By FirstnameField = By.CssSelector("input[placeholder='First Name']");
        private By LastnameField = By.CssSelector("input[placeholder='Last Name']");
        private By UsernameField = By.CssSelector("input[placeholder='Username']");
        private By EmailaddressField = By.CssSelector("input[placeholder='Email']");
        private By PhonenumberField = By.CssSelector("input[placeholder='Phone']");
        private By PasswordField = By.CssSelector("input[placeholder='Password'][name='register_pass']");
        private By RetypepasswordField = By.CssSelector("input[placeholder='Retype Password']");
        private By DropdownButton = By.CssSelector("button[title='Select your account type'] div[class='filter-option-inner-inner']");
        private By SellerButton = By.CssSelector("#bs-select-8-4");
        private By TermsandConditionBox = By.CssSelector("div[class='form-tools'] label[class='control control--checkbox'] span[class='control__indicator']");
        private By Register2Button = By.CssSelector("#houzez-register-btn");

        //METHODS TO INTERRACT WITH THE ELEMENTS

        public void ClickRegisterButton() 
        {
            driver.FindElement(RegisterButton).Click();
        }
        public void EnterFirstname()
        {
            driver.FindElement(FirstnameField).Click();
            driver.FindElement(FirstnameField).SendKeys("Ade");
        }
        public void EnterLastname()
        {
            driver.FindElement(LastnameField).Click();
            driver.FindElement(LastnameField).SendKeys("Oye");
        }
        public void EnterUsername()
        {
            driver.FindElement(UsernameField).Click();
            driver.FindElement(UsernameField).SendKeys("Adeyemi");
        }
        public void EnterEmail()
        {
            driver.FindElement(EmailaddressField).Click();
            driver.FindElement(EmailaddressField).SendKeys("gaze1919@aol.com");
        }
        public void EnterPhoneNumber()
        {
            driver.FindElement(PhonenumberField).Click();
            driver.FindElement(PhonenumberField).SendKeys("07867278355");
        }
        public void EnterPassword()
        {
            driver.FindElement(PasswordField).Click();
            driver.FindElement(PasswordField).SendKeys("GeeGaze@2020");
        }
        public void EnterRetypePassword()
        {
            driver.FindElement(RetypepasswordField).Click();
            driver.FindElement(RetypepasswordField).SendKeys("GeeGaze@2020");
        }
        public void ClickDropdownButton()
        {
            driver.FindElement(DropdownButton).Click();
        }
        public void ClickSellerOption()
        {
            driver.FindElement(SellerButton).Click();
        }
        public void CheckTandCBox()
        {
            driver.FindElement(TermsandConditionBox).Click();
        }
        public void ClickRegistrationButton()
        {
            driver.FindElement(Register2Button).Click();
        }
    }
}
