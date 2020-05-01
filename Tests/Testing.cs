using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Team4Tests.PageObject;
    
namespace Team4Tests.Tests
{
    [TestFixture]
    public class Testing
    {
        private readonly IWebDriver driver;

        public static readonly string Url = "http://52.177.12.77:8080";
        public static readonly TimeSpan implicitWait = TimeSpan.FromMilliseconds(3000);
        public static readonly string clothesButton = "By.XPath('//span[text()='Увійти']";

        public MainPage mainPage;

        public Testing()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.Navigate().GoToUrl(Url);
            mainPage = new MainPage(driver);
        }

        [Test]
        public void FirstTest()
        {
            ClothesPage clothesPage = mainPage.OpenPageOfClothes();
        }

        //[OneTimeTearDown]
        //public void OneTimeTearDown()
        //{
        //    driver.Close();
        //    driver.Quit();
        //}

    }
}
