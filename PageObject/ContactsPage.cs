using System;
using System.Linq;
using OpenQA.Selenium;
using Team4Tests.Framework;

namespace Team4Tests.PageObject
{
    public class ContactsPage : ObjectBase
    {
        private static readonly By submenuOpen = By.XPath("//select[@name='id_contact']");
        private static readonly By isEnteredMailOk = By.XPath("//div[@class='col-xs-12 alert alert-success']");
        private static readonly By supportTheme = By.XPath("//select[@name='id_contact']/option[@value='2']");
        private static readonly By inputEmailRow = By.XPath("//input[@name='from']");
        private static readonly By inputMessageArea = By.XPath("//textarea[@name='message']");
        private static readonly By addButton = By.XPath("//input[@value='Додати']");

        public ContactsPage(IWebDriver driver) : base(driver) { }

        public ContactsPage OpenThemeMenu()
        {
            Driver.FindElement(submenuOpen).Click();
            return this;
        }

        public ContactsPage ChooseTheme()
        {
            Driver.FindElement(supportTheme).Click();
            return this;
        }

        public ContactsPage EmailInput(string email)
        {
            Driver.FindElement(inputEmailRow).Click();
            Driver.FindElement(inputEmailRow).SendKeys(email);
            return this;
        }

        public ContactsPage MessageInput(string message)
        {
            Driver.FindElement(inputMessageArea).Click();
            Driver.FindElement(inputMessageArea).SendKeys(message);
            return this;
        }

        public ContactsPage ClickButtonAdd()
        {
            Driver.FindElement(addButton).Click();
            return this;
        }

        public bool isEmailOk()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isMailOk = Wait.WaitFor(() => Driver.FindElements(isEnteredMailOk).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return isMailOk;
        }
    }
}
