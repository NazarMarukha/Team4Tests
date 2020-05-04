using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class Cart : ObjectBase
    {
        public Cart(IWebDriver driver):base(driver){}
        public PrivateData ClickOnDiv()
        {
            Driver.FindElement(By.CssSelector("a[class='btn btn-primary']")).Click();
            return new PrivateData(Driver);
        }
    }
}