using System.Threading;
using NUnit.Framework;
using Team4Tests.PageObject;

namespace Team4Tests.Tests
{
    public class ShoppingTestWithAuthentification : BaseTest
    {
        private MainPage mainPage;
        private bool isOk;



        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            mainPage = new MainPage(driver);
            
        }
        [TestCase("1", "Tony", "Stark","test18@domain.net","warmachinecoll",
            "2001-12-05", "Yurko", "123213", "Backer, №221b, 1", "steet storage",
            "24862", "London", "0951681582")]
        public void BuyWithAuthentification(string sex, string name, string surname, string email, string password, string date,
            string company, string vat, string adress, string storage, string zipcod, string city, string phone)
        {
            SearchPage sp = mainPage.ClickOnT();
            sp.ClickOn();
            Thread.Sleep(2000); 
            Cart ct = sp.AddToCart();
            PrivateData pd = ct.ClickOnDiv();
            LogIn lg = pd.LogIn();
            lg.EnterEmail(email).EnterPassword(password).ContinueBuying();
            ShippingMethod SM = lg.SM(); 
            SM.Coment();
            Paying pay = SM.Pay();
            pay.SwichPay();

        }    
    }
}
