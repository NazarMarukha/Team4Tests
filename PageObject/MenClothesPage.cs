using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class MenClothesPage : ObjectBase
    {
        private static readonly By tShirtFoto = By.XPath("//a[text()='Hummingbird printed t-shirt']");
        public MenClothesPage(IWebDriver driver) : base(driver) { }

        public TShirtPage ClickOnTShirt()
        {
            Driver.FindElement(tShirtFoto).Click();
            return new TShirtPage(Driver);
        }
    }
}
