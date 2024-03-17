using OpenQA.Selenium;
using ReteHomesProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReteHomesProject.RetePageObjects
{
    class LoginPage
    {
        public IWebDriver driver;
        public LoginPage() 
        {
            driver = ReteWebHooks.driver;
        }

        private By LoginButton = By.CssSelector("body > main:nth-child(2) > header:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)");
        private By UsernameEmail = By.CssSelector("input[placeholder='Username or Email']");
        private By Password = By.CssSelector("input[placeholder='Password'][name='password']");
        private By RememberMe = By.CssSelector("label[class='control control--checkbox flex-grow-1'] span[class='control__indicator']");
        private By LoginSubmit = By.CssSelector("#houzez-login-btn");
        private By ProfileUpload = By.CssSelector("a[aria-expanded='true'] img[alt='author']");
        private By MyProfile = By.CssSelector("main[id='main-wrap'] li:nth-child(7) a:nth-child(1)");
        private By UpdateProfile = By.CssSelector("#select_user_profile_photo");

        //METHOD

        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }
        public void EnterUsernameOrEmai()
        {
         // driver.FindElement(UsernameEmail).Click();
            Thread.Sleep(2000);
            driver.FindElement(UsernameEmail).SendKeys("oye.ade@aol.com");
        }
        public void EnterPassword()
        {
            driver.FindElement(Password).Click();
            Thread.Sleep(2000);
            driver.FindElement(Password).SendKeys("GeeGaze@2020");
        }
        public void CheckRememberMeBox()
        {
            Thread.Sleep(2000);
            driver.FindElement(RememberMe).Click();
        }
        public void ClickLoginSubmitButton()
        {
            Thread.Sleep(2000);
            driver.FindElement(LoginSubmit).Click();
           
        }
        //public void ClickProfileUploadButton()
        //{
        //    driver.FindElement(ProfileUpload).Click();
           
        //}
        //public void ClickMyProfileButton()
        //{
        //    driver.FindElement(MyProfile).Click();
        //}
        //public void ClickUpdateProfileButton()
        //{
        //    driver.FindElement(UpdateProfile).Click();
        //}
    }
}
