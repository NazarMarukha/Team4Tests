using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class ProfilePage : ObjectBase
    {
        private static readonly By informationButton = By.XPath("//a[@href='http://52.177.12.77:8080/uk/identity' and @id]");
        public ProfilePage(IWebDriver driver) : base(driver) { }

        public AccountInformationPage PersonalInformation()
        {
            Driver.FindElement(informationButton).Click();
            return new AccountInformationPage(Driver);
        }
    }
}
