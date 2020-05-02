using System;
using System.Linq;
using OpenQA.Selenium;
using Team4Tests.Framework;

namespace Team4Tests.PageObject
{
    public class AccountInformationPage : ObjectBase
    {
        private static readonly By currentPasswordLine = By.XPath("//input[@name='password']");
        private static readonly By newPasswordLine = By.XPath("//input[@name='new_password']");
        private static readonly By saveButton = By.XPath("//button[@type='submit' and contains(text(),'Зберегти')]");
        private static readonly By agreeButton = By.XPath("//div[@class='col-md-6']//input[@name='psgdpr']");
        private static readonly By isChangesSucced = By.XPath("//article[@class='alert alert-success']");

        public AccountInformationPage(IWebDriver driver) : base(driver) { }

        public AccountInformationPage EnterCurrentPassword(string password)
        {
            Driver.FindElement(currentPasswordLine).Click();
            Driver.FindElement(currentPasswordLine).Clear();
            Driver.FindElement(currentPasswordLine).SendKeys(password);
            return this;
        }

        public AccountInformationPage EnterNewPassword(string newPassword)
        {
            Driver.FindElement(newPasswordLine).Click();
            Driver.FindElement(newPasswordLine).Clear();
            Driver.FindElement(newPasswordLine).SendKeys(newPassword);
            return this;
        }

        public AccountInformationPage ClickAgreeButton()
        {
            Driver.FindElement(agreeButton).Click();
            return this;
        }

        public AccountInformationPage ClickButtonSave()
        {
            Driver.FindElement(saveButton).Click();
            return this;
        }


        public bool IsChangesSaved()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isSaved = Wait.WaitFor(() => Driver.FindElements(isChangesSucced).Any());
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return isSaved;
        }
    }
}
