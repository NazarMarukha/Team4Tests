using System;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class MainPage : ObjectBase
    {
        public MainPage(IWebDriver driver) : base(driver) { }
        

        public ClothesPage OpenPageOfClothes()
        {
            Driver.FindElement(By.XPath("//span[text()='Увійти']")).Click();
            return new ClothesPage(Driver);
        }
    }
}
