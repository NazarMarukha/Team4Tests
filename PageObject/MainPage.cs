using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class MainPage : ObjectBase
    {
        private static readonly By contactsButton = By.XPath("//a[text()='Контакти']");
        private static readonly By signInButton = By.XPath("//span[text()='Увійти']");
        private static readonly By clothesButton = By.XPath("//li[@id='category-3']//a[@class='dropdown-item']");

        public MainPage(IWebDriver driver) : base(driver) { }

        public ContactsPage ClickOnContacts()
        {
            Driver.FindElement(contactsButton).Click();
            return new ContactsPage(Driver);
        }

        public SignInPage ClickOnSignIn()
        {
            Driver.FindElement(signInButton).Click();
            return new SignInPage(Driver);
        }

        public ClothesPage ClickOnClothes()
        {
            Driver.FindElement(clothesButton).Click();
            return new ClothesPage(Driver);
        }
    }
}
