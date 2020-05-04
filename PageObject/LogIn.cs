using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class LogIn : ObjectBase
    {
        public LogIn(IWebDriver driver) : base(driver)
        {
        }

        public LogIn EnterEmail(string email)
        {
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='email']")).Click();
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='email']")).Clear();
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='email']")).SendKeys(email);
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='email']")).SendKeys(Keys.Tab);
            return this;
        }

        public LogIn EnterPassword(string password)
        {
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='password']")).Click();
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='password']")).Clear();
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='password']"))
                .SendKeys(password);
            Driver.FindElement(By.XPath("//div[@id='checkout-login-form']//input[@name='password']"))
                .SendKeys(Keys.Tab);
            return this;
        }

        public LogIn ContinueBuying()
        {
            Driver.FindElement(
                By.XPath("//footer[@class='form-footer text-sm-center clearfix']//button[@name='continue']")).Click();
            return this;
        }

        public ShippingMethod SM()
        {
            Driver.FindElement(By.XPath("//div[@class='clearfix']//button[@name='confirm-addresses']")).Click();
            return  new ShippingMethod(Driver);
        }
    }
}