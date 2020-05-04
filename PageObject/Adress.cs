using NUnit.Framework;
using OpenQA.Selenium;

namespace Team4Tests.PageObject
{
    public class Adress : ObjectBase
    {
        public Adress(IWebDriver driver) : base(driver){}
        
         public Adress Company(string company)
        {
            Driver.FindElement(By.Name("company")).Click();
            Driver.FindElement(By.Name("company")).Clear();
            Driver.FindElement(By.Name("company")).SendKeys(company);
            Driver.FindElement(By.Name("company")).SendKeys(Keys.Tab);
            return this;
        }

        public Adress PDV(string vat)
        {
            Driver.FindElement(By.Name("vat_number")).Click();
            Driver.FindElement(By.Name("vat_number")).Clear();
            Driver.FindElement(By.Name("vat_number")).SendKeys(vat);
            Driver.FindElement(By.Name("vat_number")).SendKeys(Keys.Tab);
            return this;
        }

        public Adress _Adress(string adress)
        {
            Driver.FindElement(By.Name("address1")).Click();
            Driver.FindElement(By.Name("address1")).Clear();
            Driver.FindElement(By.Name("address1")).SendKeys(adress);
            Driver.FindElement(By.Name("address1")).SendKeys(Keys.Tab);
            return this; 
        }

        public Adress Storage(string storage)
        {
            Driver.FindElement(By.Name("address2")).Click();
            Driver.FindElement(By.Name("address2")).Clear();
            Driver.FindElement(By.Name("address2")).SendKeys(storage);
            Driver.FindElement(By.Name("address2")).SendKeys(Keys.Tab);
            return this; 
        }

        public Adress PostCode(string zipcod)
        {
            Driver.FindElement(By.Name("postcode")).Click();
            Driver.FindElement(By.Name("postcode")).Clear();
            Driver.FindElement(By.Name("postcode")).SendKeys(zipcod);
            Driver.FindElement(By.Name("postcode")).SendKeys(Keys.Tab);
            return this; 
        }

        public Adress City(string city)
        {
            Driver.FindElement(By.Name("city")).Click();
            Driver.FindElement(By.Name("city")).Clear();
            Driver.FindElement(By.Name("city")).SendKeys(city);
            Driver.FindElement(By.Name("city")).SendKeys(Keys.Tab);
            return this; 
        }

        public Adress Phone(string phone)
        {
            Driver.FindElement(By.Name("phone")).Click();
            Driver.FindElement(By.Name("phone")).Clear();
            Driver.FindElement(By.Name("phone")).SendKeys(phone);
            Driver.FindElement(By.Name("phone")).SendKeys(Keys.Tab);
            return this; 
        }

        public ShippingMethod SM()
        {
            Driver.FindElement(By.Name("confirm-addresses")).Click();
            return new ShippingMethod(Driver);
        }
    }
}