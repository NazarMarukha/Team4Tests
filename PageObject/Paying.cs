using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class Paying : ObjectBase
    {
        public Paying(IWebDriver driver) : base(driver){}
        
        public Paying SwichPay()
        {
            Driver.FindElement(By.Id("payment-option-1")).Click();
            Driver.FindElement(By.Id("conditions_to_approve[terms-and-conditions]")).Click();
            Driver.FindElement(By.XPath("//div[@id='payment-confirmation']//button[@class='btn btn-primary center-block']")).Click();
            return this;
        }
    }
}