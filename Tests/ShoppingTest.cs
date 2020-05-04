using System.Threading;
using NUnit.Framework;
using Team4Tests.Framework;
using Team4Tests.PageObject;

namespace Team4Tests.Tests
{
    public class ShoppingTest : BaseTest
    {
        private MainPage mainPage;
        
        
        [OneTimeSetUp]
        public void OneTimeSetUp()
        { 
            mainPage = new MainPage(driver);
            
        }
    
        [TestCase("1", "Tony", "Stark","test17@domain.net","warmachinecoll",
            "2001-12-05", "Yurko", "123213", "Backer, №221b, 1", "steet storage",
            "24862", "London", "0951681582")]
        public void ShoppiningTest(string sex, string name, string surname, string email, string password, string date,
            string company, string vat, string adress, string storage, string zipcod, string city, string phone)
        {
            SearchPage sp = mainPage.ClickOnT();
            sp.ClickOn();
            Thread.Sleep(2000); 
            Cart ct = sp.AddToCart();
            PrivateData pd = ct.ClickOnDiv();
            pd.Sex(sex).FirstName(name).LastName(surname).Email(email).Password(password).Brithday(date).Agree();
            Adress aadress = pd.ClickOnContinue();
            
            aadress.Company(company).PDV(vat)._Adress(adress).Storage(storage).PostCode(zipcod).City(city).Phone(phone);
            ShippingMethod SM = aadress.SM();
            SM.Coment();
            Paying pay = SM.Pay();
            pay.SwichPay();

        }
    }
}