using System.Threading;
using NUnit.Framework;
using Team4Tests.PageObject;

namespace Team4Tests.Tests
{
    public class ChangeLanguegeAndCarrencyTest : BaseTest
    {
        private MainPage mainPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            mainPage = new MainPage(driver);
      
        }

        [TestCase("en")]
        [TestCase("uk")]
        public void ChoseTest(string lang)
        {
            mainPage.ChangeLanguage(lang);
            Thread.Sleep(1000);
        }

        [TestCase("Euro")]
        [TestCase("Українська гривня")]
        [TestCase("US Dollar")]
        public void ChoseCurrency(string title)
        {
            mainPage.ChangeCurrency(title);
            Thread.Sleep(1000);
        }
    }
}