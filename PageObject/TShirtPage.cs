using System;
using OpenQA.Selenium;
using Team4Tests.Framework;
using System.Linq;

namespace Team4Tests.PageObject
{
    public class TShirtPage : ObjectBase
    {
        private static readonly By isSuchQuantityUnavailable = By.XPath("//span[@id='product-availability']//i[@class='material-icons product-unavailable']");
        private static readonly By quantityInput = By.XPath("//input[@id='quantity_wanted']");
        private static readonly By orderButton = By.XPath("//a[@class='btn btn-primary']");
        public TShirtPage(IWebDriver driver) : base(driver) { } 

        public TShirtPage EnterQuantityOfTShirts(string quantity)
        {
            Driver.FindElement(quantityInput).Click();
            Driver.FindElement(quantityInput).Clear();
            Driver.FindElement(quantityInput).SendKeys(quantity);
            return this;
        }

        public CartPage ToOrder()
        {
            Driver.FindElement(orderButton).Click();
            return new CartPage(Driver);
        }

        public bool IsAvailableSuchQuantity()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            bool isNotAvailable = Wait.WaitFor(() => Driver.FindElements(isSuchQuantityUnavailable).Any(),2000);
            Driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            return !(isNotAvailable);
        }
    }
}
