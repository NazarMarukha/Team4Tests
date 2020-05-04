using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class ShippingMethod : ObjectBase
    {
        public  ShippingMethod (IWebDriver driver) : base(driver){}
        
        public ShippingMethod Coment()
        {
            Driver.FindElement(By.Id("delivery_message")).Click();
            Driver.FindElement(By.Id("delivery_message")).Clear();
            Driver.FindElement(By.Id("delivery_message")).SendKeys("Нарешті я це зробив!!!");
            Driver.FindElement(By.Id("delivery_message")).SendKeys(Keys.Tab);
            return this;
        }

        public Paying Pay()
        {
            Driver.FindElement(By.Name("confirmDeliveryOption")).Click();
            return new Paying(Driver);
        }
    }
}