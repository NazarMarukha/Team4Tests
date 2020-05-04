using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class PrivateData : ObjectBase
    {
        public PrivateData(IWebDriver driver) : base(driver){}
        
         public LogIn LogIn()
        {
            Driver.FindElement(By.XPath("//ul[@class='nav nav-inline my-2']//a[@class='nav-link ']")).Click();
            return new LogIn(Driver);
        }
        public PrivateData Sex(string sex)
        {
            Driver.FindElement(By.XPath($"//div[@class='col-md-6 form-control-valign']//input[@value='{sex}']")).Click();
            return this;
        }
        public PrivateData FirstName(string name)
        {
            Driver.FindElement(By.Name("firstname")).Click();
            Driver.FindElement(By.Name("firstname")).Clear();
            Driver.FindElement(By.Name("firstname")).SendKeys(name);
            Driver.FindElement(By.Name("firstname")).SendKeys(Keys.Tab);
            return this;
        }

        public PrivateData LastName(string surname)
        {
            Driver.FindElement(By.Name("lastname")).Click();
            Driver.FindElement(By.Name("lastname")).Clear();
            Driver.FindElement(By.Name("lastname")).SendKeys(surname);
            Driver.FindElement(By.Name("lastname")).SendKeys(Keys.Tab);
            return this;
        }

        public PrivateData Email(string email)
        {
            Driver.FindElement(By.Name("email")).Click();
            Driver.FindElement(By.Name("email")).Clear();
            Driver.FindElement(By.Name("email")).SendKeys(email);
            Driver.FindElement(By.Name("email")).SendKeys(Keys.Tab);
            return this;
        }

        public PrivateData Password(string password)
        {
            Driver.FindElement(By.Name("password")).Click();
            Driver.FindElement(By.Name("password")).Clear();
            Driver.FindElement(By.Name("password")).SendKeys(password);
            Driver.FindElement(By.Name("password")).SendKeys(Keys.Tab);
            return this;
        }

        public PrivateData Brithday(string date)
        {
            Driver.FindElement(By.Name("birthday")).Click();
            Driver.FindElement(By.Name("birthday")).Clear();
            Driver.FindElement(By.Name("birthday")).SendKeys(date);
            Driver.FindElement(By.Name("birthday")).SendKeys(Keys.Tab);
            return this;
        }
        
        public PrivateData Agree()
        {
            Driver.FindElement(By.XPath("//span[@class= 'custom-checkbox']//input[@name='psgdpr']")).Click();
            return this;
        }

        public Adress ClickOnContinue()//footer[@class='form-footer clearfix']//input[@name='submitCreate']
        {
            Driver.FindElement((By.Name("continue"))).Click();
            return new Adress(Driver);
        }
    }
}