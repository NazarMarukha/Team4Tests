using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team4Tests.Framework;

namespace Team4Tests.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected readonly IWebDriver driver;
        
        protected BaseTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = Settings.implicitWait;
            driver.Navigate().GoToUrl(Settings.Url);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => driver.Quit();
    }
}