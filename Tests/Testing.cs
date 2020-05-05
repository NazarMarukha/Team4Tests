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

        [TestCase(true, "_cox_@ukr.net", "help, Help, HELP me, ПОЧЕМУ НЕТУ ПОМОЩИ")] //Adding contact
        [TestCase(false, "_co@_121", "")]
        public void FirstTest(bool isPositive, string email, string message) 
        {
            ContactsPage contactsPage = mainPage.ClickOnContacts();
 
            bool isContactAdded = contactsPage.OpenThemeMenu()
                        .ChooseTheme()
                        .EmailInput(email)
                        .MessageInput(message)
                        .ClickButtonAdd()
                        .isEmailOk();

            Assert.That(isContactAdded, Is.EqualTo(isPositive), $"Contact was added {(isContactAdded ? "succesfully" : "unsuccesfully")}");
                   
        }

        [TestCase(true, "test1@domain.com", "password23", "password2319")] 
        [TestCase(false, "test1@domain.com", "password2319", "pass")]
        public void SecondTest(bool isPositive, string email, string password, string newPassword) //Changing password
        {
            SignInPage signInPage = mainPage.ClickOnSignIn();
            signInPage.EnterEmail(email)
                      .EnterPassword(password);

            ProfilePage profilePage = signInPage.ClickSignInAccount();
            AccountInformationPage accountInformation = profilePage.PersonalInformation();

            accountInformation.EnterCurrentPassword(password)
                              .EnterNewPassword(newPassword)
                              .ClickAgreeButton()
                              .ClickButtonSave();

            bool isChangesSaved = accountInformation.IsChangesSaved();
            Assert.That(isChangesSaved, Is.EqualTo(isPositive), $"Changes was saved {(isChangesSaved ? "succesfully" : "unsuccesfully")}");
        }

        [TestCase(true,"50")]
        [TestCase(false,"2000")]
        public void ThirdTest(bool isPositive, string quantity) //View is such quantity of T-Shirts available to buy
        {
            ClothesPage clothesPage = mainPage.ClickOnClothes();
            MenClothesPage menClothesPage = clothesPage.ClickMenClothes();
            TShirtPage tShirtPage = menClothesPage.ClickOnTShirt();
            tShirtPage.EnterQuantityOfTShirts(quantity);

            bool isSuchQuantityAvailable = tShirtPage.IsAvailableSuchQuantity();
            Assert.That(isSuchQuantityAvailable, Is.EqualTo(isPositive), $"Such quantity of T-Shirts were {(isSuchQuantityAvailable ? "available" : "unavailable")}");
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
