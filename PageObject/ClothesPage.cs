using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class ClothesPage : ObjectBase
    {
        private static readonly By menClothesButton = By.XPath("//a[text()='Men']");

        public ClothesPage(IWebDriver driver) : base(driver) { }

        public MenClothesPage ClickMenClothes()
        {
            Driver.FindElement(menClothesButton).Click();
            return new MenClothesPage(Driver);
        }
    }
}
