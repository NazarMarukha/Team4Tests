using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Team4Tests.Framework;
using Team4Tests.PageObject;
    
namespace Team4Tests.Tests
{
    [TestFixture]
    public class Testing
    {
        private readonly IWebDriver driver;

        public MainPage mainPage;

        public Testing()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            driver.Navigate().GoToUrl(Settings.Url);
            mainPage = new MainPage(driver);
        }

        [Test]

        public void FirstTest() //
        {
            
        }

        public void SecondTest() //
        {

        }

        public void ThirdTest() // 
        {

        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
