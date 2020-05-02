using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class SignInPage : ObjectBase
    {
        private static readonly By emailInputLine = By.XPath("//div[@class='col-md-6']/input[@type='email']");
        private static readonly By passwordInputLine = By.XPath("//input[@name='password']");
        private static readonly By buttonSignInAccount = By.XPath("//button[@id='submit-login']");

        public SignInPage(IWebDriver driver) : base(driver) { }

        public SignInPage EnterEmail(string email)
        {
            Driver.FindElement(emailInputLine).Click();
            Driver.FindElement(emailInputLine).Clear();
            Driver.FindElement(emailInputLine).SendKeys(email + Keys.Tab);
            return this;
        }

        public SignInPage EnterPassword(string password)
        {
            Driver.FindElement(passwordInputLine).SendKeys(password);
            return this;
        }

        public ProfilePage ClickSignInAccount()
        {
            Driver.FindElement(buttonSignInAccount).Click();
            return new ProfilePage(Driver);
        }
        
    }
}
