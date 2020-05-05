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
        public SearchPage ClickOnT()
        {
            Driver.FindElement(By.XPath("//div[@class='thumbnail-container']//a[@class='thumbnail product-thumbnail']")).Click();
            return new SearchPage(Driver);
        }

        public MainPage ChangeLanguage(string lang)
        {
            Driver.FindElement(By.ClassName("language-selector-wrapper")).Click();
            Driver.FindElement(By.XPath($"//ul[@class = 'dropdown-menu hidden-sm-down']//a[@data-iso-code=\"{lang}\"]")).Click();
            return this;
        }

        public MainPage ChangeCurrency(string title)
        {
            Driver.FindElement(By.XPath("//div[@id='_desktop_currency_selector']//button[@class='hidden-sm-down btn-unstyle']")).Click();
            Driver.FindElement(By.XPath($"//ul[@class = 'dropdown-menu hidden-sm-down']//a[@title=\"{title}\"]")).Click();
            return this;
        }
    }
}
